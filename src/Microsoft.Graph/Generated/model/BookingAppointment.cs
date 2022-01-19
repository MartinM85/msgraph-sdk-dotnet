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
    /// The type Booking Appointment.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<BookingAppointment>))]
    public partial class BookingAppointment : Entity
    {
    
        /// <summary>
        /// Gets or sets additional information.
        /// Additional information that is sent to the customer when an appointment is confirmed.
        /// </summary>
        [JsonPropertyName("additionalInformation")]
        public string AdditionalInformation { get; set; }
    
        /// <summary>
        /// Gets or sets customers.
        /// It lists down the customer properties for an appointment. An appointment will contain a list of customer information and each unit will indicate the properties of a customer who is part of that appointment. Optional.
        /// </summary>
        [JsonPropertyName("customers")]
        public IEnumerable<BookingCustomerInformationBase> Customers { get; set; }
    
        /// <summary>
        /// Gets or sets customer time zone.
        /// The time zone of the customer. For a list of possible values, see dateTimeTimeZone.
        /// </summary>
        [JsonPropertyName("customerTimeZone")]
        public string CustomerTimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets duration.
        /// The length of the appointment, denoted in ISO8601 format.
        /// </summary>
        [JsonPropertyName("duration")]
        public Duration Duration { get; set; }
    
        /// <summary>
        /// Gets or sets end date time.
        /// The date, time, and time zone that the appointment ends.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeTimeZone EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets filled attendees count.
        /// The current number of customers in the appointment.
        /// </summary>
        [JsonPropertyName("filledAttendeesCount")]
        public Int32? FilledAttendeesCount { get; set; }
    
        /// <summary>
        /// Gets or sets is location online.
        /// True indicates that the appointment will be held online. Default value is false.
        /// </summary>
        [JsonPropertyName("isLocationOnline")]
        public bool? IsLocationOnline { get; set; }
    
        /// <summary>
        /// Gets or sets join web url.
        /// The URL of the online meeting for the appointment.
        /// </summary>
        [JsonPropertyName("joinWebUrl")]
        public string JoinWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets maximum attendees count.
        /// The maximum number of customers allowed in an appointment.
        /// </summary>
        [JsonPropertyName("maximumAttendeesCount")]
        public Int32? MaximumAttendeesCount { get; set; }
    
        /// <summary>
        /// Gets or sets opt out of customer email.
        /// True indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.
        /// </summary>
        [JsonPropertyName("optOutOfCustomerEmail")]
        public bool? OptOutOfCustomerEmail { get; set; }
    
        /// <summary>
        /// Gets or sets post buffer.
        /// The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.
        /// </summary>
        [JsonPropertyName("postBuffer")]
        public Duration PostBuffer { get; set; }
    
        /// <summary>
        /// Gets or sets pre buffer.
        /// The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.
        /// </summary>
        [JsonPropertyName("preBuffer")]
        public Duration PreBuffer { get; set; }
    
        /// <summary>
        /// Gets or sets price.
        /// The regular price for an appointment for the specified bookingService.
        /// </summary>
        [JsonPropertyName("price")]
        public double? Price { get; set; }
    
        /// <summary>
        /// Gets or sets price type.
        /// A setting to provide flexibility for the pricing structure of services. Possible values are: undefined, fixedPrice, startingAt, hourly, free, priceVaries, callUs, notSet, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("priceType")]
        public BookingPriceType? PriceType { get; set; }
    
        /// <summary>
        /// Gets or sets reminders.
        /// The value of this property is only available when reading an individual booking appointment by id.
        /// </summary>
        [JsonPropertyName("reminders")]
        public IEnumerable<BookingReminder> Reminders { get; set; }
    
        /// <summary>
        /// Gets or sets self service appointment id.
        /// An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer.
        /// </summary>
        [JsonPropertyName("selfServiceAppointmentId")]
        public string SelfServiceAppointmentId { get; set; }
    
        /// <summary>
        /// Gets or sets service id.
        /// The ID of the bookingService associated with this appointment.
        /// </summary>
        [JsonPropertyName("serviceId")]
        public string ServiceId { get; set; }
    
        /// <summary>
        /// Gets or sets service location.
        /// The location where the service is delivered.
        /// </summary>
        [JsonPropertyName("serviceLocation")]
        public Location ServiceLocation { get; set; }
    
        /// <summary>
        /// Gets or sets service name.
        /// This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the service id.
        /// </summary>
        [JsonPropertyName("serviceName")]
        public string ServiceName { get; set; }
    
        /// <summary>
        /// Gets or sets service notes.
        /// The value of this property is only available when reading an individual booking appointment by id.
        /// </summary>
        [JsonPropertyName("serviceNotes")]
        public string ServiceNotes { get; set; }
    
        /// <summary>
        /// Gets or sets sms notifications enabled.
        /// True indicates SMS notifications will be sent to the customers for the appointment. Default value is false.
        /// </summary>
        [JsonPropertyName("smsNotificationsEnabled")]
        public bool? SmsNotificationsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets staff member ids.
        /// The ID of each bookingStaffMember who is scheduled in this appointment.
        /// </summary>
        [JsonPropertyName("staffMemberIds")]
        public IEnumerable<string> StaffMemberIds { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// The date, time, and time zone that the appointment begins.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeTimeZone StartDateTime { get; set; }
    
    }
}

