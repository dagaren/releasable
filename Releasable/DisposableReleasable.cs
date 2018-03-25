// <copyright file="DisposableReleasable.cs" company="David Garcinuño Enríquez">
// Copyright (c) David Garcinuño Enríquez. All rights reserved.
// </copyright>

namespace Dagaren.Releasable
{
    using System;

    public class DisposableReleasable<T> : IReleasable<T>
    {
        public DisposableReleasable(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public void Dispose()
        {
            IDisposable disposable = this.Value as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }

            this.Value = default(T);
        }
    }
}
