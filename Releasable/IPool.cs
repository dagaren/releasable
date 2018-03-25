// <copyright file="IPool.cs" company="David Garcinuño Enríquez">
// Copyright (c) David Garcinuño Enríquez. All rights reserved.
// </copyright>

namespace Dagaren.Releasable
{
    public interface IPool<T>
    {
        int NumElements { get; }

        T Get();

        void Return(T obj);
    }
}
