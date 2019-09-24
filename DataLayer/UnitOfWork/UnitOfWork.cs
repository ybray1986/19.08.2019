using DataLayer.Repository;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        DbContext db;
        public UnitOfWork(DbContext model)
        {
            this.db = model;
        }

        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        Repository<Authors> _authorUoWRepository;
        public Repository<Authors> AuthorUoWRepository
        {
            get
            {
                return _authorUoWRepository == null ? new Repository<Authors>(db) : _authorUoWRepository;
            }
        }

        Repository<Books> _booksUoWRepository;
        public Repository<Books> BookUoWRepository
        {
            get
            {
                return _booksUoWRepository == null ? new Repository<Books>(db) : _booksUoWRepository;
            }
        }

        Repository<Genre> _genreUoWRepository;
        public Repository<Genre> GenreUoWRepository
        {
            get
            {
                return _genreUoWRepository == null ? new Repository<Genre>(db) : _genreUoWRepository;
            }
        }

        Repository<Library> _libraryUoWRepository;
        public Repository<Library> LibraryUoWRepository
        {
            get
            {
                return _libraryUoWRepository == null ? new Repository<Library>(db) : _libraryUoWRepository;
            }
        }

        Repository<Users> _usersUoWRepository;
        public Repository<Users> UserUoWRepository
        {
            get
            {
                return _usersUoWRepository == null ? new Repository<Users>(db) : _usersUoWRepository;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                    if (db != null)
                    {
                        db.Dispose();
                    }
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~UnitOfWork() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}