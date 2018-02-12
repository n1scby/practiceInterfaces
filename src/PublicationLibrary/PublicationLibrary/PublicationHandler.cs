using System;
using System.Collections.Generic;
using System.Text;

namespace PublicationLibrary
{
    public class PublicationHandler
    {
        private IPublicationInterface _pubInterface;

        public PublicationHandler(IPublicationInterface pubInterface)
        {
            _pubInterface = pubInterface;
        }

        public string GetPubFullName()
        {
            return _pubInterface.GetFullName();
        }

    }
}
