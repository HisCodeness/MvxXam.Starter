namespace MvxXam.Starter.Services
{
    /// <summary>
    /// Test app service interface
    /// </summary>
    public interface IAppService : IService
    {
        /// <summary>
        /// What time is it ?
        /// </summary>
        /// <returns></returns>
        string WhatTimeIsIt();
    }
}
