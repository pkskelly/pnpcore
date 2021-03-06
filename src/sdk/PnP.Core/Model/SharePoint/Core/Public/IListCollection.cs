﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PnP.Core.Services;

namespace PnP.Core.Model.SharePoint
{
    /// <summary>
    /// Public interface to define a collection of List objects of SharePoint Online
    /// </summary>
    public interface IListCollection : IQueryable<IList>, IDataModelCollection<IList>, ISupportPaging
    {
        #region Extension Methods
        /// <summary>
        /// Gets a list by title
        /// </summary>
        /// <param name="title">Title of the list to get</param>
        /// <returns>Loaded list, null is not found</returns>
        public Task<IList> GetByTitleAsync(string title, params Expression<Func<IList, object>>[] expressions);

        /// <summary>
        /// Gets a list by title
        /// </summary>
        /// <param name="title">Title of the list to get</param>
        /// <returns>Loaded list, null is not found</returns>
        public IList GetByTitleLegacy(string title, params Expression<Func<IList, object>>[] expressions);

        /// <summary>
        /// Adds a new list
        /// </summary>
        /// <param name="title">Title of the list</param>
        /// <param name="templateType">Template type</param>
        /// <returns>Newly added list</returns>
        public Task<IList> AddAsync(string title, ListTemplateType templateType);

        /// <summary>
        /// Adds a new list
        /// </summary>
        /// <param name="batch">Batch to use</param>
        /// <param name="title">Title of the list</param>
        /// <param name="templateType">Template type</param>
        /// <returns>Newly added list</returns>
        public IList Add(Batch batch, string title, ListTemplateType templateType);

        /// <summary>
        /// Adds a new list
        /// </summary>
        /// <param name="title">Title of the list</param>
        /// <param name="templateType">Template type</param>
        /// <returns>Newly added list</returns>
        public IList Add(string title, ListTemplateType templateType);
        #endregion
    }
}
