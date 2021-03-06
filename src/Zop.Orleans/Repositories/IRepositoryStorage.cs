﻿using System.Threading.Tasks;

namespace Zop.Repositories
{
    /// <summary>
    /// 仓储基类
    /// </summary>
    public interface IRepositoryStorage
    {
        /// <summary>
        /// 读取仓储
        /// </summary>
        /// <param name="id">标识Id</param>
        /// <returns></returns>
        Task<object> ReadAsync(object id);
        /// <summary>
        /// 写入仓储
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<object> AddAsync( object entity);
        /// <summary>
        /// 修改仓储
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<object> ModifyAsync(object entity);
        /// <summary>
        /// 删除仓储
        /// </summary>
        /// <param name="entity">实体信息</param>
        /// <returns></returns>
        Task ClearAsync(object entity);
    }
}
