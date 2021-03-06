﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.Domain.Common;
using VirtoCommerce.Domain.Marketing.Model;

namespace VirtoCommerce.Domain.Marketing.Services
{
	public interface IMarketingPromoEvaluator
	{
		/// <summary>
		/// Evaluate promotion for specific context
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		PromotionResult EvaluatePromotion(IEvaluationContext context);
	}
}
