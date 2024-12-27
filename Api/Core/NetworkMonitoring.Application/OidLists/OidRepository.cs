using NetworkMonitoring.Application.OidLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring.Api.Application.OidLists
{
    public static class OidRepository
    {
        public static List<string> GetOidTypes()
        {
            List<string> oidTypes = new List<string>
            {
                "Tcp",
                "Udp",
                "System",
                "Snmp Stats",
                "Ip",
                "Interface",
                "Icmp",
                "Egp",
                "Egp Comm",
                "Egp AT"
            };
            return oidTypes;
        }
        public static List<string> GetTcpOids()
        {
            List<string> oids = new List<string>
            {
                TcpOids.TcpActiveOpens,
                TcpOids.TcpPassiveOpens,
                TcpOids.TcpAttemptFails,
                TcpOids.TcpEstabResets,
                TcpOids.TcpCurrEstab,
                TcpOids.TcpInSegs,
                TcpOids.TcpOutSegs,
                TcpOids.TcpRetransSegs,
                TcpOids.TcpInErrs,
                TcpOids.TcpOutRsts,
                TcpOids.TcpInCsumErrors,
                TcpOids.TcpOutCsumErrors,
                TcpOids.TcpHCInSegs,
                TcpOids.TcpHCOutSegs,
                TcpOids.TcpHCInOctets
            };
            return oids;
        }
        public static List<string> GetTcpOidNames()
        {
            List<string> oids = new List<string>
            {
                "TcpActiveOpens",
                "TcpPassiveOpens",
                "TcpAttemptFails",
                "TcpEstabResets",
                "TcpCurrEstab",
                "TcpInSegs",
                "TcpOutSegs",
                "TcpRetransSegs",
                "TcpInErrs",
                "TcpOutRsts",
                "TcpInCsumErrors",
                "TcpOutCsumErrors",
                "TcpHCInSegs",
                "TcpHCOutSegs",
                "TcpHCInOctets"
            };
            return oids;
        }
        public static List<string> GetUdpOids()
        {
            List<string> oids = new List<string>
            {
                UdpOids.UdpInDatagrams,
                UdpOids.UdpNoPorts,
                UdpOids.UdpInErrors,
                UdpOids.UdpOutDatagrams,
                UdpOids.UdpTable
            };
            return oids;
        }
        public static List<string> GetUdpOidNames()
        {
            List<string> oids = new List<string>
            {
                "UdpInDatagrams",
                "UdpNoPorts",
                "UdpInErrors",
                "UdpOutDatagrams",
                "UdpTable"
            };
            return oids;
        }
        public static List<string> GetSystemOids()
        {
            List<string> oids = new List<string>
            {
                SystemOids.SysDescr,
                SystemOids.SysObjectID,
                SystemOids.SysUpTime,
                SystemOids.SysContact,
                SystemOids.SysName,
                SystemOids.SysLocation,
                SystemOids.SysServices

            };
            return oids;
        }
        public static List<string> GetSystemOidNames()
        {
            List<string> oids = new List<string>
            {
                "SysDescr",
                "SysObjectID",
                "SysUpTime",
                "SysContact",
                "SysName",
                "SysLocation",
                "SysServices"

            };
            return oids;
        }
        public static List<string> GetSnmpStatsOids()
        {
            List<string> oids = new List<string>
            {
                SnmpStatsOids.SnmpInPkts,
                SnmpStatsOids.SnmpOutPkts,
                SnmpStatsOids.SnmpInBadVersions,
                SnmpStatsOids.SnmpInBadCommunityNames,
                SnmpStatsOids.SnmpInBadCommunityUses,
                SnmpStatsOids.SnmpInASNParseErrs,
                SnmpStatsOids.SnmpInTooBigs,
                SnmpStatsOids.SnmpInNoSuchNames,
                SnmpStatsOids.SnmpInBadValues,
                SnmpStatsOids.SnmpInReadOnlys,
                SnmpStatsOids.SnmpInGenErrs,
                SnmpStatsOids.SnmpInTotalReqVars,
                SnmpStatsOids.SnmpInTotalSetVars,
                SnmpStatsOids.SnmpInGetRequests,
                SnmpStatsOids.SnmpInGetNexts,
                SnmpStatsOids.SnmpInSetRequests,
                SnmpStatsOids.SnmpInGetResponses,
                SnmpStatsOids.SnmpInTraps,
                SnmpStatsOids.SnmpOutTooBigs,
                SnmpStatsOids.SnmpOutNoSuchNames,
                SnmpStatsOids.SnmpOutBadValues,
                SnmpStatsOids.SnmpOutGenErrs,
                SnmpStatsOids.SnmpOutGetRequests,
                SnmpStatsOids.SnmpOutGetNexts,
                SnmpStatsOids.SnmpOutSetRequests,
                SnmpStatsOids.SnmpOutGetResponses,
                SnmpStatsOids.SnmpOutTraps,
                SnmpStatsOids.SnmpEnableAuthenTraps

            };
            return oids;
        }
        public static List<string> GetSnmpStatsOidNames()
        {
            List<string> oids = new List<string>
            {
                "SnmpInPkts",
                "SnmpOutPkts",
                "SnmpInBadVersions",
                "SnmpInBadCommunityNames",
                "SnmpInBadCommunityUses",
                "SnmpInASNParseErrs",
                "SnmpInTooBigs",
                "SnmpInNoSuchNames",
                "SnmpInBadValues",
                "SnmpInReadOnlys",
                "SnmpInGenErrs",
                "SnmpInTotalReqVars",
                "SnmpInTotalSetVars",
                "SnmpInGetRequests",
                "SnmpInGetNexts",
                "SnmpInSetRequests",
                "SnmpInGetResponses",
                "SnmpInTraps",
                "SnmpOutTooBigs",
                "SnmpOutNoSuchNames",
                "SnmpOutBadValues",
                "SnmpOutGenErrs",
                "SnmpOutGetRequests",
                "SnmpOutGetNexts",
                "SnmpOutSetRequests",
                "SnmpOutGetResponses",
                "SnmpOutTraps",
                "SnmpEnableAuthenTraps"

            };
            return oids;
        }
        public static List<string> GetIpOids()
        {
            List<string> oids = new List<string>
            {
                IpOids.IpForwarding,
                IpOids.IpDefaultTTL,
                IpOids.IpInReceives,
                IpOids.IpInHdrErrors,
                IpOids.IpInAddrErrors,
                IpOids.IpForwDatagrams,
                IpOids.IpInUnknownProtos,
                IpOids.IpInDiscards,
                IpOids.IpInDelivers,
                IpOids.IpOutRequests,
                IpOids.IpOutDiscards,
                IpOids.IpOutNoRoutes,
                IpOids.IpReasmTimeout,
                IpOids.IpReasmReqds,
                IpOids.IpReasmOKs,
                IpOids.IpReasmFails,
                IpOids.IpFragOKs,
                IpOids.IpFragFails,
                IpOids.IpFragCreates,
                IpOids.IpAddrTable,
                IpOids.IpRouteTable,
                IpOids.IpNetToMediaTable,
                IpOids.IpRoutingDiscards,
                IpOids.LastBitMask
            };
            return oids;
        }
        public static List<string> GetIpOidNmes()
        {
            List<string> oids = new List<string>
            {
                "IpForwarding",
                "IpDefaultTTL",
                "IpInReceives",
                "IpInHdrErrors",
                "IpInAddrErrors",
                "IpForwDatagrams",
                "IpInUnknownProtos",
                "IpInDiscards",
                "IpInDelivers",
                "IpOutRequests",
                "IpOutDiscards",
                "IpOutNoRoutes",
                "IpReasmTimeout",
                "IpReasmReqds",
                "IpReasmOKs",
                "IpReasmFails",
                "IpFragOKs",
                "IpFragFails",
                "IpFragCreates",
                "IpAddrTable",
                "IpRouteTable",
                "IpNetToMediaTable",
                "IpRoutingDiscards",
                "LastBitMask"
            };
            return oids;
        }
        public static List<string> GetInterfaceOids()
        {
            List<string> oids = new List<string>
            {
                InterfaceOids.IfNumber,
                InterfaceOids.IfTable
            };
            return oids;
        }
        public static List<string> GetInterfaceOidNames()
        {
            List<string> oids = new List<string>
            {
                "IfNumber",
                "IfTable"
            };
            return oids;
        }
        public static List<string> GetIcmpOids()
        {
            List<string> oids = new List<string>
            {
                IcmpOids.IcmpInMsgs,
                IcmpOids.IcmpInErrors,
                IcmpOids.IcmpInDestUnreachs,
                IcmpOids.IcmpInTimeExcds,
                IcmpOids.IcmpInParmProbs,
                IcmpOids.IcmpInSrcQuenchs,
                IcmpOids.IcmpInRedirects,
                IcmpOids.IcmpInEchos,
                IcmpOids.IcmpInEchoReps,
                IcmpOids.IcmpInTimestamps,
                IcmpOids.IcmpInTimestampReps,
                IcmpOids.IcmpInAddrMasks,
                IcmpOids.IcmpInAddrMaskReps,
                IcmpOids.IcmpOutMsgs,
                IcmpOids.IcmpOutErrors,
                IcmpOids.IcmpOutDestUnreachs,
                IcmpOids.IcmpOutTimeExcds,
                IcmpOids.IcmpOutParmProbs,
                IcmpOids.IcmpOutSrcQuenchs,
                IcmpOids.IcmpOutRedirects,
                IcmpOids.IcmpOutEchos,
                IcmpOids.IcmpOutEchoReps,
                IcmpOids.IcmpOutTimestamps,
                IcmpOids.IcmpOutTimestampReps,
                IcmpOids.IcmpOutAddrMasks,
                IcmpOids.IcmpOutAddrMaskReps
            };
            return oids;
        }
        public static List<string> GetIcmpOidNames()
        {
            List<string> oids = new List<string>
            {
                "IcmpInMsgs",
                "IcmpInErrors",
                "IcmpInDestUnreachs",
                "IcmpInTimeExcds",
                "IcmpInParmProbs",
                "IcmpInSrcQuenchs",
                "IcmpInRedirects",
                "IcmpInEchos",
                "IcmpInEchoReps",
                "IcmpInTimestamps",
                "IcmpInTimestampReps",
                "IcmpInAddrMasks",
                "IcmpInAddrMaskReps",
                "IcmpOutMsgs",
                "IcmpOutErrors",
                "IcmpOutDestUnreachs",
                "IcmpOutTimeExcds",
                "IcmpOutParmProbs",
                "IcmpOutSrcQuenchs",
                "IcmpOutRedirects",
                "IcmpOutEchos",
                "IcmpOutEchoReps",
                "IcmpOutTimestamps",
                "IcmpOutTimestampReps",
                "IcmpOutAddrMasks",
                "IcmpOutAddrMaskReps"
            };
            return oids;
        }
        public static List<string> GetEgpOids()
        {
            List<string> oids = new List<string>
            {
                EgpOids.EgpInMsgs,
                EgpOids.EgpInErrors,
                EgpOids.EgpOutMsgs,
                EgpOids.EgpOutErrors,
                EgpOids.EgpNeighTable,
                EgpOids.EgpAs
            };
            return oids;
        }
        public static List<string> GetEgpOidNames()
        {
            List<string> oids = new List<string>
            {
                "EgpInMsgs",
                "EgpInErrors",
                "EgpOutMsgs",
                "EgpOutErrors",
                "EgpNeighTable",
                "EgpAs"
            };
            return oids;
        }
        public static List<string> GetEgpCommunicationOids()
        {
            List<string> oids = new List<string>
            {
                CommunicationOids.Ds1E1Mib,
                CommunicationOids.IsdnMib,
                CommunicationOids.FibreChannelMgmt,
                CommunicationOids.DocsisMib
            };
            return oids;
        }
        public static List<string> GetEgpCommunicationOidNames()
        {
            List<string> oids = new List<string>
            {
                "Ds1E1Mib",
                "IsdnMib",
                "FibreChannelMgmt",
                "DocsisMib"
            };
            return oids;
        }
        public static List<string> GetEgpAtOids()
        {
            List<string> oids = new List<string>
            {
                AtOids.AtTable
            };
            return oids;
        }
        public static List<string> GetEgpAtOidNames()
        {
            List<string> oids = new List<string>
            {
                "AtTable"
            };
            return oids;
        }
    }
}
