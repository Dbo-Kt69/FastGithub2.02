﻿using System.Threading;
using System.Threading.Tasks;

namespace FastGithub.Dns
{
    /// <summary>
    /// Dns冲突解决者
    /// </summary>
    interface IConflictSolver
    {
        /// <summary>
        /// 解决冲突
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task SolveAsync(CancellationToken cancellationToken);

        /// <summary>
        /// 恢复冲突
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task RestoreAsync(CancellationToken cancellationToken);
    }
}