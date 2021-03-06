﻿// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ContactItemField.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace PodioPCL.Models.ItemFields
{
	/// <summary>
	/// Class ContactItemField.
	/// </summary>
    public class ContactItemField : ItemField
    {
		/// <summary>
		/// The _contacts
		/// </summary>
        private List<Contact> _contacts;

		/// <summary>
		/// Gets the contacts.
		/// </summary>
		/// <value>The contacts.</value>
        public IEnumerable<Contact> Contacts
        {
            get
            {
                 return this.valuesAs<Contact>(_contacts);
            }
        }

		/// <summary>
		/// The profile_id's of the contacts
		/// </summary>
		/// <value>The contact ids.</value>
        public IEnumerable<int> ContactIds
        {
            set
            {
                ensureValuesInitialized();
                foreach (var contactId in value)
                {
                    var jobject = new JObject();
                    jobject["value"] = contactId;
                    this.Values.Add(jobject);
                }
            }
        }
		/// <summary>
		/// Sets the contact identifier.
		/// </summary>
		/// <value>The contact identifier.</value>
        public int  ContactId
        {
            set
            {
                ensureValuesInitialized();
                
                    var jobject = new JObject();
                    jobject["value"] = value;
                    this.Values.Add(jobject);
                
            }
        }
      
    }
}
