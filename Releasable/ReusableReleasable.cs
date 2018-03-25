// <copyright file="ReusableReleasable.cs" company="David Garcinuño Enríquez">
// Copyright (c) David Garcinuño Enríquez. All rights reserved.
// </copyright>

namespace Dagaren.Releasable
{
    using System;

    public class ReusableReleasable<T> : IReleasable<T>
    {
        private Action<T> reuseAction;

        public ReusableReleasable(T value, Action<T> reuseAction)
        {
            this.Value = value;

            this.reuseAction = reuseAction ?? throw new ArgumentNullException(nameof(reuseAction));
        }

        public T Value { get; private set; }

        public void Dispose()
        {
            this.reuseAction(this.Value);
            this.Value = default(T);
        }
    }
}
