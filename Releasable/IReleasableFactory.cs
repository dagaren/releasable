// <copyright file="IReleasableFactory.cs" company="David Garcinuño Enríquez">
// Copyright (c) David Garcinuño Enríquez. All rights reserved.
// </copyright>

namespace Dagaren.Releasable
{
    public interface IReleasableFactory<T>
    {
        IReleasable<T> Get();
    }
}
