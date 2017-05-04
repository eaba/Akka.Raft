﻿using AkkaRaft.Shared.Candidates;
using AkkaRaft.Shared.Heartbeats;
using System;
using System.Collections.Generic;
using System.Text;

namespace AkkaRaft.Shared.Nodes
{
    public class NodeEvents
    {
        public static Action OnElectionTimeout { get; set; }
        public static Action<Heartbeat> OnHeartbeat { get; set; }
        public static Action OnJoinedCluster { get; set; }
        public static Action OnHeartbeatResponse { get; set; }
        public static Action<int> OnMemberChanged { get; set; }
        public static Action<long,int> OnGotVote { get; set; }
        public static Func<VoteRequest,bool> OnVoteRequest { get; set; }
        
        public enum Events
        {
            None=0,
            OnElectionTimeout=1,
            MemberChanged=2,
            OnHeartbeat=3,
        }
        
        public Events Event { get; private set; }
        public object[] Args { get; private set; }
        public NodeEvents(Events e,params object[] args)
        {
            Event = e;
            Args = args;
        }
    }
}