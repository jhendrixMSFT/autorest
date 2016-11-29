// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.PetstoreV2NoSync
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SwaggerPetstoreV2.
    /// </summary>
    public static partial class SwaggerPetstoreV2Extensions
    {
            /// <summary>
            /// Add a new pet to the store
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Pet object that needs to be added to the store
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Pet> AddPetAsync(this ISwaggerPetstoreV2 operations, Pet body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddPetWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing pet
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Pet object that needs to be added to the store
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdatePetAsync(this ISwaggerPetstoreV2 operations, Pet body, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.UpdatePetWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Finds Pets by status
            /// </summary>
            /// <remarks>
            /// Multiple status values can be provided with comma seperated strings
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='status'>
            /// Status values that need to be considered for filter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Pet>> FindPetsByStatusAsync(this ISwaggerPetstoreV2 operations, IList<string> status, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FindPetsByStatusWithHttpMessagesAsync(status, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Finds Pets by tags
            /// </summary>
            /// <remarks>
            /// Muliple tags can be provided with comma seperated strings. Use tag1, tag2,
            /// tag3 for testing.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tags'>
            /// Tags to filter by
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Pet>> FindPetsByTagsAsync(this ISwaggerPetstoreV2 operations, IList<string> tags, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FindPetsByTagsWithHttpMessagesAsync(tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Find pet by Id
            /// </summary>
            /// <remarks>
            /// Returns a single pet
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='petId'>
            /// Id of pet to return
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Pet> GetPetByIdAsync(this ISwaggerPetstoreV2 operations, long petId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPetByIdWithHttpMessagesAsync(petId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a pet in the store with form data
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='petId'>
            /// Id of pet that needs to be updated
            /// </param>
            /// <param name='fileContent'>
            /// File to upload.
            /// </param>
            /// <param name='fileName'>
            /// Updated name of the pet
            /// </param>
            /// <param name='status'>
            /// Updated status of the pet
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdatePetWithFormAsync(this ISwaggerPetstoreV2 operations, long petId, Stream fileContent, string fileName = default(string), string status = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.UpdatePetWithFormWithHttpMessagesAsync(petId, fileContent, fileName, status, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Deletes a pet
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='petId'>
            /// Pet id to delete
            /// </param>
            /// <param name='apiKey'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeletePetAsync(this ISwaggerPetstoreV2 operations, long petId, string apiKey = "", CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeletePetWithHttpMessagesAsync(petId, apiKey, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns pet inventories by status
            /// </summary>
            /// <remarks>
            /// Returns a map of status codes to quantities
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, int?>> GetInventoryAsync(this ISwaggerPetstoreV2 operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetInventoryWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Place an order for a pet
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// order placed for purchasing the pet
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Order> PlaceOrderAsync(this ISwaggerPetstoreV2 operations, Order body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PlaceOrderWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Find purchase order by Id
            /// </summary>
            /// <remarks>
            /// For valid response try integer IDs with value &lt;= 5 or &gt; 10. Other
            /// values will generated exceptions
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// Id of pet that needs to be fetched
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Order> GetOrderByIdAsync(this ISwaggerPetstoreV2 operations, string orderId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOrderByIdWithHttpMessagesAsync(orderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete purchase order by Id
            /// </summary>
            /// <remarks>
            /// For valid response try integer IDs with value &lt; 1000. Anything above
            /// 1000 or nonintegers will generate API errors
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// Id of the order that needs to be deleted
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteOrderAsync(this ISwaggerPetstoreV2 operations, string orderId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteOrderWithHttpMessagesAsync(orderId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Create user
            /// </summary>
            /// <remarks>
            /// This can only be done by the logged in user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Created user object
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateUserAsync(this ISwaggerPetstoreV2 operations, User body, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.CreateUserWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Creates list of users with given input array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// List of user object
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateUsersWithArrayInputAsync(this ISwaggerPetstoreV2 operations, IList<User> body, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.CreateUsersWithArrayInputWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Creates list of users with given input array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// List of user object
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateUsersWithListInputAsync(this ISwaggerPetstoreV2 operations, IList<User> body, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.CreateUsersWithListInputWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Logs user into the system
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// The user name for login
            /// </param>
            /// <param name='password'>
            /// The password for login in clear text
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> LoginUserAsync(this ISwaggerPetstoreV2 operations, string username, string password, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LoginUserWithHttpMessagesAsync(username, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Logs out current logged in user session
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task LogoutUserAsync(this ISwaggerPetstoreV2 operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.LogoutUserWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get user by user name
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// The name that needs to be fetched. Use user1 for testing.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> GetUserByNameAsync(this ISwaggerPetstoreV2 operations, string username, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetUserByNameWithHttpMessagesAsync(username, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updated user
            /// </summary>
            /// <remarks>
            /// This can only be done by the logged in user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// name that need to be deleted
            /// </param>
            /// <param name='body'>
            /// Updated user object
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateUserAsync(this ISwaggerPetstoreV2 operations, string username, User body, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.UpdateUserWithHttpMessagesAsync(username, body, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Delete user
            /// </summary>
            /// <remarks>
            /// This can only be done by the logged in user.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='username'>
            /// The name that needs to be deleted
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteUserAsync(this ISwaggerPetstoreV2 operations, string username, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteUserWithHttpMessagesAsync(username, null, cancellationToken).ConfigureAwait(false);
            }

    }
}

