using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealCommunicationsDemos.Hubs
{
    public class VideoHub : Hub
    {

        //Relay Offers to connected clients
        public void MakeOffer(string offer)
        {
            Clients.Others.onOffer(offer);
        }

        //Relay ICE Candidates to connected clients
        public void CandidateFound(string candidate)
        {
            Clients.Others.onCandidate(candidate);
        }

        //Relay Answers to connected clients
        public void SendAnswer(string answer)
        {
            Clients.Others.onAnswer(answer);
        }
    }
}
