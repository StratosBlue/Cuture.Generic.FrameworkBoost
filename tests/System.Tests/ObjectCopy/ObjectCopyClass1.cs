﻿// <Auto-Generated></Auto-Generated>

namespace System.Tests.ObjectCopy
{
    internal class ObjectCopyClass1
    {
        private string _privateFields;

        public string PublicFields;

        public string casefields;

        public string PublicProperty { get; set; }

        public string caseproperty { get; set; }

        private string PrivateProperty { get; set; }

        public string SpecialProperty { get; }

        public ObjectCopyClass1(string privateFields, string privateProperty, string specialProperty)
        {
            _privateFields = privateFields;
            PrivateProperty = privateProperty;
            SpecialProperty = specialProperty;
        }

        public string GetPrivateFieldsValue() => _privateFields;

        public string GetPrivatePropertyValue() => PrivateProperty;

        public ObjectCopyClass1 Clone() => MemberwiseClone() as ObjectCopyClass1;

        public override bool Equals(object obj)
        {
            return obj is ObjectCopyClass1 @class &&
                   _privateFields == @class._privateFields &&
                   PublicFields == @class.PublicFields &&
                   casefields == @class.casefields &&
                   PublicProperty == @class.PublicProperty &&
                   caseproperty == @class.caseproperty &&
                   PrivateProperty == @class.PrivateProperty &&
                   SpecialProperty == @class.SpecialProperty;
        }
    }
}