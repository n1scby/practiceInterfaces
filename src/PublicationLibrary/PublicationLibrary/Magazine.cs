using System;
using System.Collections.Generic;
using System.Text;

namespace PublicationLibrary
{
    public class Magazine : IPublicationInterface
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PubDate { get; set; }
        private int _issueNum;

        public int IssueNum
        {
            get { return _issueNum; }
            set
            {
                if (value == 0)
                {
                    throw new Exception($"Whoa!  That issue ({value}) is invalid.");
                }

                _issueNum = value; }
            }


        public string GetFullName()
        {
            return $"Magazine: {Title}  Issue: {IssueNum}";
        }
    }
}
