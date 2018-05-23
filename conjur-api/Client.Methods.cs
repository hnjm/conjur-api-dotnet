// <copyright file="Client.Methods.cs" company="Conjur Inc.">
//     Copyright (c) 2016-2018 Conjur Inc. All rights reserved.
// </copyright>
// <summary>
//     Conjur Client methods delegating to entity-specific classes.
// </summary>

namespace Conjur
{
    using System.Collections.Generic;

    /// <summary>
    /// Entity-specific methods for the Client facade.
    /// </summary>
    public partial class Client
    {
        /// <summary>
        /// Creates an object representing the named variable.
        /// </summary>
        /// Note the existence of the variable is not verified.
        /// <param name="name">The variable name.</param>
        /// <returns>Variable object.</returns>
        /// <seealso cref="Variable()"/>
        public Variable Variable(string name)
        {
            return new Variable(this, name);
        }

        /// <summary>
        /// Search for variables
        /// </summary>
        /// <param name="query">Query for search.</param>
        /// <param name="actingAs">Fully qualified role name. For example MyCompanyName:group:security_admin. Note support for this value is limited in the current version of this library.</param>
        /// <returns>List of variables matching the query.</returns>
        /// Note enumerating can incur network requests to fetch more data.
        public IEnumerable<Variable> ListVariables(string query = null, string actingAs = null)
        {
            return Conjur.Variable.List(this, query, actingAs);
        }

        /// <summary>
        /// Search for users
        /// </summary>
        /// <param name="query">Query for search.</param>
        /// <param name="actingAs">Fully qualified role name. For example MyCompanyName:group:security_admin. Note support for this value is limited in the current version of this library.</param>
        /// <returns>List of users matching the query.</returns>
        /// Note enumerating can incur network requests to fetch more data.
        public IEnumerable<User> ListUsers(string query = null, string actingAs = null)
        {
            return Conjur.User.List(this, query, actingAs);
        }

        /// <summary>
        /// Creates a host using a host factory token.
        /// </summary>
        /// <returns>The created host.</returns>
        /// <param name="name">Name of the host to create.</param>
        /// <param name="hostFactoryToken">Host factory token.</param>
        public Host CreateHost(string name, string hostFactoryToken)
        {
            return new HostFactoryToken(this, hostFactoryToken)
                .CreateHost(name);
        }

        /// <summary>
        /// Creates an object representing a Conjur resource.
        /// </summary>
        /// <param name="kind">Resource kind.</param>
        /// <param name="id">Resource identifier.</param>
        /// <returns>Object representing the specified resource.</returns>
        public Resource Resource(string kind, string id)
        {
            return new Resource(this, kind, id);
        }
    }
}
