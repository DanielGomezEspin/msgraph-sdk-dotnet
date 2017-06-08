// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ISharedDriveItemItemsCollectionRequestBuilder.
    /// </summary>
    public partial interface ISharedDriveItemItemsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ISharedDriveItemItemsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ISharedDriveItemItemsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDriveItemRequestBuilder"/> for the specified DriveItem.
        /// </summary>
        /// <param name="id">The ID for the DriveItem.</param>
        /// <returns>The <see cref="IDriveItemRequestBuilder"/>.</returns>
        IDriveItemRequestBuilder this[string id] { get; }

        
    }
}