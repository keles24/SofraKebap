﻿using SofraKebab.DataAccessLayer.Abstract;
using SofraKebab.DataAccessLayer.Concreate;
using SofraKebab.DataAccessLayer.Repositories;
using SofraKebab.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.DataAccessLayer.EntityFramework
{
	public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
	{
		public EfTestimonialDal(SofraKebabContext context) : base(context)
		{
		}
	}
}