using UnityEngine;

namespace FactoryMethod
{
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }

        public override string ToString() => GetType().Name;
    }

    #region Расчёт скидки по стране

    public class CountryDiscountService : DiscountService
        {
            private readonly string _countryIdentifier;

            public CountryDiscountService(string countryIdentifier)
            {
                this._countryIdentifier = countryIdentifier; 
            }

            public override int DiscountPercentage
            {
                get
                {
                    switch (_countryIdentifier)
                    {
                        case "BE":
                            return 20;
                        default:
                            return 10;
                    }
                }
        }
    }
    #endregion

    #region Расчёт скидки по коду
    
        public class CodeDiscountService : DiscountService
        {
            private readonly Guid _code;

            public CodeDiscountService(Guid code)
            {
                _code = code;
            }


            public override int DiscountPercentage
            {
                get => 15;
            }
        }

        public class Guid
        {
            public static Guid NewGuid()
            {
                Guid guid = new Guid();
                Debug.Log("Код создался!");
                return guid;
            }
        }
    #endregion

    #region Классы Фабрик

        public abstract class DiscountFactory
        {
            public abstract DiscountService CreateDiscountService();
        }


        public class CodeDiscountFactory : DiscountFactory
        {
            private readonly Guid _code;

            public CodeDiscountFactory(Guid code)
            {
                _code = code;
            }

            public override DiscountService CreateDiscountService()
            {
                return new CodeDiscountService(_code);
            }
        }
        
        public class CountryDiscountFactory : DiscountFactory
        {
            private readonly string _country;

            public CountryDiscountFactory(string country)
            {
                _country = country;
            }

            public override DiscountService CreateDiscountService()
            {
                return new CountryDiscountService(_country);
            }
        }
        #endregion
}