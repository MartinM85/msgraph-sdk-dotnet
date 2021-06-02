// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Contact.
    /// </summary>
    public partial class Contact : OutlookItem
    {
    
        ///<summary>
        /// The Contact constructor
        ///</summary>
        public Contact()
        {
            this.ODataType = "microsoft.graph.contact";
        }

        /// <summary>
        /// Gets or sets assistant name.
        /// The name of the contact's assistant.
        /// </summary>
        [JsonPropertyName("assistantName")]
        public string AssistantName { get; set; }
    
        /// <summary>
        /// Gets or sets birthday.
        /// The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("birthday")]
        public DateTimeOffset? Birthday { get; set; }
    
        /// <summary>
        /// Gets or sets business address.
        /// The contact's business address.
        /// </summary>
        [JsonPropertyName("businessAddress")]
        public PhysicalAddress BusinessAddress { get; set; }
    
        /// <summary>
        /// Gets or sets business home page.
        /// The business home page of the contact.
        /// </summary>
        [JsonPropertyName("businessHomePage")]
        public string BusinessHomePage { get; set; }
    
        /// <summary>
        /// Gets or sets business phones.
        /// The contact's business phone numbers.
        /// </summary>
        [JsonPropertyName("businessPhones")]
        public IEnumerable<string> BusinessPhones { get; set; }
    
        /// <summary>
        /// Gets or sets children.
        /// The names of the contact's children.
        /// </summary>
        [JsonPropertyName("children")]
        public IEnumerable<string> Children { get; set; }
    
        /// <summary>
        /// Gets or sets company name.
        /// The name of the contact's company.
        /// </summary>
        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// The contact's department.
        /// </summary>
        [JsonPropertyName("department")]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets email addresses.
        /// The contact's email addresses.
        /// </summary>
        [JsonPropertyName("emailAddresses")]
        public IEnumerable<EmailAddress> EmailAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets file as.
        /// The name the contact is filed under.
        /// </summary>
        [JsonPropertyName("fileAs")]
        public string FileAs { get; set; }
    
        /// <summary>
        /// Gets or sets generation.
        /// The contact's generation.
        /// </summary>
        [JsonPropertyName("generation")]
        public string Generation { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// The contact's given name.
        /// </summary>
        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets home address.
        /// The contact's home address.
        /// </summary>
        [JsonPropertyName("homeAddress")]
        public PhysicalAddress HomeAddress { get; set; }
    
        /// <summary>
        /// Gets or sets home phones.
        /// The contact's home phone numbers.
        /// </summary>
        [JsonPropertyName("homePhones")]
        public IEnumerable<string> HomePhones { get; set; }
    
        /// <summary>
        /// Gets or sets im addresses.
        /// The contact's instant messaging (IM) addresses.
        /// </summary>
        [JsonPropertyName("imAddresses")]
        public IEnumerable<string> ImAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets initials.
        /// The contact's initials.
        /// </summary>
        [JsonPropertyName("initials")]
        public string Initials { get; set; }
    
        /// <summary>
        /// Gets or sets job title.
        /// The contact’s job title.
        /// </summary>
        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; }
    
        /// <summary>
        /// Gets or sets manager.
        /// The name of the contact's manager.
        /// </summary>
        [JsonPropertyName("manager")]
        public string Manager { get; set; }
    
        /// <summary>
        /// Gets or sets middle name.
        /// The contact's middle name.
        /// </summary>
        [JsonPropertyName("middleName")]
        public string MiddleName { get; set; }
    
        /// <summary>
        /// Gets or sets mobile phone.
        /// The contact's mobile phone number.
        /// </summary>
        [JsonPropertyName("mobilePhone")]
        public string MobilePhone { get; set; }
    
        /// <summary>
        /// Gets or sets nick name.
        /// The contact's nickname.
        /// </summary>
        [JsonPropertyName("nickName")]
        public string NickName { get; set; }
    
        /// <summary>
        /// Gets or sets office location.
        /// The location of the contact's office.
        /// </summary>
        [JsonPropertyName("officeLocation")]
        public string OfficeLocation { get; set; }
    
        /// <summary>
        /// Gets or sets other address.
        /// Other addresses for the contact.
        /// </summary>
        [JsonPropertyName("otherAddress")]
        public PhysicalAddress OtherAddress { get; set; }
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// The ID of the contact's parent folder.
        /// </summary>
        [JsonPropertyName("parentFolderId")]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets personal notes.
        /// The user's notes about the contact.
        /// </summary>
        [JsonPropertyName("personalNotes")]
        public string PersonalNotes { get; set; }
    
        /// <summary>
        /// Gets or sets profession.
        /// The contact's profession.
        /// </summary>
        [JsonPropertyName("profession")]
        public string Profession { get; set; }
    
        /// <summary>
        /// Gets or sets spouse name.
        /// The name of the contact's spouse/partner.
        /// </summary>
        [JsonPropertyName("spouseName")]
        public string SpouseName { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// The contact's surname.
        /// </summary>
        [JsonPropertyName("surname")]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// The contact's title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets yomi company name.
        /// The phonetic Japanese company name of the contact.
        /// </summary>
        [JsonPropertyName("yomiCompanyName")]
        public string YomiCompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets yomi given name.
        /// The phonetic Japanese given name (first name) of the contact.
        /// </summary>
        [JsonPropertyName("yomiGivenName")]
        public string YomiGivenName { get; set; }
    
        /// <summary>
        /// Gets or sets yomi surname.
        /// The phonetic Japanese surname (last name)  of the contact.
        /// </summary>
        [JsonPropertyName("yomiSurname")]
        public string YomiSurname { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the contact. Nullable.
        /// </summary>
        [JsonPropertyName("extensions")]
        public IContactExtensionsCollectionPage Extensions { get; set; }

        /// <summary>
        /// Gets or sets extensionsNextLink.
        /// </summary>
        [JsonPropertyName("extensions@odata.nextLink")]
        public string ExtensionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties")]
        public IContactMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets multiValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties@odata.nextLink")]
        public string MultiValueExtendedPropertiesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// Optional contact picture. You can get or set a photo for a contact.
        /// </summary>
        [JsonPropertyName("photo")]
        public ProfilePhoto Photo { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the contact. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties")]
        public IContactSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets singleValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties@odata.nextLink")]
        public string SingleValueExtendedPropertiesNextLink { get; set; }
    
    }
}

