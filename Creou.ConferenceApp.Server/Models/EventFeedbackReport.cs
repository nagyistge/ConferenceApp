﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Creou.ConferenceApp.Server.Models
{
	public class EventFeedbackReport
	{
		public int Id { get; set; }

		public Attendee Attendee { get; set; }

		public byte RateLocation { get; set; }

		public byte RateVenue { get; set; }

		public byte RateSessions { get; set; }

		public byte RateLunch { get; set; }
		
		public string LikeComments { get; set; }

		public string  DislikeComments { get; set; }

		public string SuggestedLocation { get; set; }

		public int CompanySize { get; set; }

		public byte YearsInvolved { get; set; }

		public int Status { get; set; }

		public string TechnologiesUsed { get; set; }

		public string DiscoveryMethod { get; set; }

		public string AttendeeLocation { get; set; }

		public string TransportationMethod { get; set; }
	}

}