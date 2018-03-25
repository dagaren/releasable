// <copyright file="PooledFactory.cs" company="David Garcinuño Enríquez">
// Copyright (c) David Garcinuño Enríquez. All rights reserved.
// </copyright>

namespace Dagaren.Releasable
{
    using System;

    public class PooledFactory<T> : IReleasableFactory<T>
    {
        private readonly IPool<T> pool;

        private readonly object synco = new object();

        public PooledFactory(IPool<T> pool)
        {
            this.pool = pool ?? throw new ArgumentNullException();
        }

        public IReleasable<T> Get()
        {
            lock (this.synco)
            {
                return new ReusableReleasable<T>(this.pool.Get(), this.Release);
            }
        }

        private void Release(T obj)
        {
            lock (this.synco)
            {
                this.pool.Return(obj);
            }
        }
    }
}
