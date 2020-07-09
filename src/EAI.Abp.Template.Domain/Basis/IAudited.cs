using System;

namespace $safeprojectname$.Basis
{
    public interface IAudited
    {
        /// <summary>
        /// System creation date time of this entity, set by the system.
        /// </summary>
        DateTime? CreatedAt { get; set; }

        int? CreatedById { get; set; }

        /// <summary>
        /// System update date time of this entity, set by the system.
        /// </summary>
        DateTime? UpdatedAt { get; set; }

        int? UpdatedById { get; set; }
    }
}