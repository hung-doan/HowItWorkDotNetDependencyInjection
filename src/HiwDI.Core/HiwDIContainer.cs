using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HiwDI.Core
{

    public class HiwDIContainer
    {
        /// <summary>
        /// _bindingRecords including mapping for injection
        /// </summary>
        private readonly Dictionary<Type, Type> _bindingRecords;

        
        public HiwDIContainer()
        {
            _bindingRecords = new Dictionary<Type, Type>();
        }

        /// <summary>
        /// Register a type mapping with the container, where the created instances will use
        /// the given types
        /// </summary>
        /// <typeparam name="TFrom">Interface name</typeparam>
        /// <typeparam name="TTo">Imlement class name</typeparam>
        /// <returns></returns>
        public HiwDIContainer Register<TFrom, TTo>()
            where TTo : TFrom
        {
            var fromType = typeof(TFrom);
            var toType = typeof(TTo);


            //Add the Registeration to the map
            _bindingRecords.Add(fromType, toType);

            return this;
        }

        /// <summary>
        /// Get Dependence of type
        /// </summary>
        /// <param name="from">The Principal class</param>
        /// <returns></returns>
        public object Inject(Type from)
        {

            // Get destination type
            Type toType;

            if(!_bindingRecords.TryGetValue(from, out toType))
            {
                return Activator.CreateInstance(from, null);
            }
            

            // Get constructor of destination type.
            // If there is multiple `constructor`, we get the first one.
            var toConstructor = toType.GetConstructors().First();

            // Get all arguments of the constructor
            var toConstructorArgsType = toConstructor.GetParameters();
            var toConstructorArgsValue = new object[toConstructorArgsType.Length];

            // Create an instance of constructor argument.
            for (var i = 0; i < toConstructorArgsType.Length; i++)
            {
                var param = toConstructorArgsType[i];
                toConstructorArgsValue[i] = Inject(param.ParameterType);
            }


            // Create an instance of destination type.
            var result = Activator.CreateInstance(toType, toConstructorArgsValue);

            return result;
        }

        /// <summary>
        /// Get Dependence of `TFrom`
        /// </summary>
        /// <typeparam name="TFrom">The Principal class</typeparam>
        /// <returns>The Dependence</returns>
        public TFrom Inject<TFrom>()
        {
            TFrom result;
            var fromType = typeof(TFrom);
            result = (TFrom)Inject(fromType);
            return result;
        }
    }
}
