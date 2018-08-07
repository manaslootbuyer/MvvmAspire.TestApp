using System;
using System.IO;
using MarcelloDB;
using MarcelloDB.Collections;
using MarcelloDB.Index;
using MvvmAspire;
using TestApp.Services.Interfaces;
using Xamarin.Forms;

namespace TestApp.Repository
{
    public abstract class BaseNoSqlRepository
    {
        private static Session _session;
        private static object _sessionLock = new object();

        protected Session Session
        {
            get
            {
                lock (_sessionLock)
                {
                    if (_session != null) return _session;
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Data");
                    Directory.CreateDirectory(path);
                    var platform = DependencyService.Get<IMarcelloService>().GetInstance();
                    _session = new Session(platform, path);
                    return _session;
                }
            }
        }

        protected Collection<T, TId> InitalizeCollection<T, TId>(Func<T, TId> idFunct, string collectionName)
        {
            lock (_sessionLock)
            {
                return Session[$"{collectionName}.data"].Collection(collectionName, idFunct);
            }
        }

        protected Collection<T, TId, TIndex> InitalizeCollection<T, TId, TIndex>(Func<T, TId> idFunct, string collectionName) where TIndex : IndexDefinition<T>, new()
        {
            lock (_sessionLock)
            {
                return Session[$"{collectionName}.data"].Collection<T, TId, TIndex>(collectionName, idFunct);
            }
        }
    }
}