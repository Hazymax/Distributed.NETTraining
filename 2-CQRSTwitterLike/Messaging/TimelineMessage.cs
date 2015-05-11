using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging
{
    public struct TimelineMessage
    {
        private readonly UserId _ownerID;
        private readonly DateTime _date;        
        private readonly int _nb_favoris;
        private readonly int _nb_retweets;
        private readonly String _content;

        public TimelineMessage(UserId owner,DateTime date, int nbfavoris, int nbretweet,String content) {
            this._ownerID = owner;
            this._date = date;
            this._nb_favoris = nbfavoris;
            this._nb_retweets = nbretweet;
            this._content = content;
        }

        public UserId OwnerId
        {
            get { return _ownerID; }
        }

        public int NbFavoris
        {
            get { return _nb_favoris; }
        }

        public int NbRetweets
        {
            get { return _nb_retweets; }
        }

        public String Content
        {
            get { return _content; }
        }

    }
}
