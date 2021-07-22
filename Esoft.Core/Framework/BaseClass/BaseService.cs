using AutoMapper;
using Esoft.Core.Entity;
using Esoft.Core.Framework.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esoft.Core.Framework.BaseClass
{
	// What does this class ???
	public abstract class BaseService<T>/*:LoggerBase<T>*/
	{
		private IMapper _mapper;

		protected IMapper Mapper => _mapper ?? (_mapper = (IMapper)_serviceCollection.GetService(typeof(IMapper)));
		
		private ApplicationDbContext _dbContext;

		protected ApplicationDbContext DbContext => _dbContext ?? (_dbContext = 
																(ApplicationDbContext)_serviceCollection
																.GetService(typeof(ApplicationDbContext)));

		private readonly IServiceProvider _serviceCollection;

		protected BaseService(IServiceProvider services /*ContextHolder context = null*/) /*: base(services, context)*/
		{
			_serviceCollection = services;
		}
	}
}
