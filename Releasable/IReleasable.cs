// <copyright file="IReleasable.cs" company="David Garcinuño Enríquez">
// Copyright (c) David Garcinuño Enríquez. All rights reserved.
// </copyright>

namespace Dagaren.Releasable
{
    using System;

    public interface IReleasable<out T> : IDisposable
    {
        T Value { get; }
    }
}
