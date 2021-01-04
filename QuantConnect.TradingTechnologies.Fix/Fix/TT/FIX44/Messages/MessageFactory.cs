// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix;
using QuantConnect.Fix.TT.FIX44.Fields;
using QuantConnect.Fix.TT.FIX44.Messages;

namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class MessageFactory : IMessageFactory
        {
            public ICollection<string> GetSupportedBeginStrings()
            {
				return new [] { QuickFix.FixValues.BeginString.FIX44 };
            }

			
            public QuickFix.Message Create(string beginString, Fields.ApplVerID applVerId, string msgType)
            {
                return Create(beginString, msgType);
            }


            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case Heartbeat.MsgType: return new Heartbeat();
                    case TestRequest.MsgType: return new TestRequest();
                    case ResendRequest.MsgType: return new ResendRequest();
                    case Reject.MsgType: return new Reject();
                    case SequenceReset.MsgType: return new SequenceReset();
                    case Logout.MsgType: return new Logout();
                    case ExecutionReport.MsgType: return new ExecutionReport();
                    case OrderCancelReject.MsgType: return new OrderCancelReject();
                    case NewOrderMultileg.MsgType: return new NewOrderMultileg();
                    case NewOrderSingle.MsgType: return new NewOrderSingle();
                    case MultilegOrderCancelReplace.MsgType: return new MultilegOrderCancelReplace();
                    case OrderCancelReplaceRequest.MsgType: return new OrderCancelReplaceRequest();
                    case OrderCancelRequest.MsgType: return new OrderCancelRequest();
                    case SecurityDefinitionRequest.MsgType: return new SecurityDefinitionRequest();
                    case SecurityDefinition.MsgType: return new SecurityDefinition();
                    case SecurityStatusRequest.MsgType: return new SecurityStatusRequest();
                    case Messages.SecurityStatus.MsgType: return new Messages.SecurityStatus();
                    case MarketDataRequest.MsgType: return new MarketDataRequest();
                    case MarketDataRequestReject.MsgType: return new MarketDataRequestReject();
                    case MarketDataSnapshot.MsgType: return new MarketDataSnapshot();
                    case MarketDataIncrementalRefresh.MsgType: return new MarketDataIncrementalRefresh();
                    case QuoteRequest.MsgType: return new QuoteRequest();
                    case Logon.MsgType: return new Logon();
                    case BusinessMessageReject.MsgType: return new BusinessMessageReject();
                    case OrderStatusRequest.MsgType: return new OrderStatusRequest();
                    case TradeCaptureReport.MsgType: return new TradeCaptureReport();
                    case TradeCaptureReportAck.MsgType: return new TradeCaptureReportAck();
                    case News.MsgType: return new News();
                    case XMLnonFIX.MsgType: return new XMLnonFIX();
                    case OrderMassCancelReport.MsgType: return new OrderMassCancelReport();
                    case OrderMassAction.MsgType: return new OrderMassAction();
                    case HistoryRequest.MsgType: return new HistoryRequest();
                    case OutOfBandRecoveryRequest.MsgType: return new OutOfBandRecoveryRequest();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoPartyIDs: return new ExecutionReport.NoPartyIDsGroup();
                        case Fields.CustomTags.NoSecurityAltID: return new ExecutionReport.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoStrategyParameters: return new ExecutionReport.NoStrategyParametersGroup();
                        case Fields.CustomTags.NoLegs: return new ExecutionReport.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new ExecutionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case Fields.CustomTags.LegNoFills: return new ExecutionReport.NoLegsGroup.LegNoFillsGroup();
                        case Fields.CustomTags.NoLinks: return new ExecutionReport.NoLinksGroup();
                        case Fields.CustomTags.NoFills: return new ExecutionReport.NoFillsGroup();
                        case Fields.CustomTags.NoOrderAttributes: return new ExecutionReport.NoOrderAttributesGroup();
                    }
                }

                if (OrderCancelReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoStrategyParameters: return new OrderCancelReject.NoStrategyParametersGroup();
                        case Fields.CustomTags.NoSecurityAltID: return new OrderCancelReject.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoLegs: return new OrderCancelReject.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new OrderCancelReject.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case Fields.CustomTags.LegNoFills: return new OrderCancelReject.NoLegsGroup.LegNoFillsGroup();
                    }
                }

                if (NewOrderMultileg.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoSecurityAltID: return new NewOrderMultileg.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoLegs: return new NewOrderMultileg.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new NewOrderMultileg.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case Fields.CustomTags.NoStrategyParameters: return new NewOrderMultileg.NoStrategyParametersGroup();
                        case Fields.CustomTags.NoPartyIDs: return new NewOrderMultileg.NoPartyIDsGroup();
                        case Fields.CustomTags.NoOrderAttributes: return new NewOrderMultileg.NoOrderAttributesGroup();
                        case Fields.CustomTags.NoLinks: return new NewOrderMultileg.NoLinksGroup();
                    }
                }

                if (NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoSecurityAltID: return new NewOrderSingle.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoPartyIDs: return new NewOrderSingle.NoPartyIDsGroup();
                        case Fields.CustomTags.NoStrategyParameters: return new NewOrderSingle.NoStrategyParametersGroup();
                        case Fields.CustomTags.NoLegs: return new NewOrderSingle.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new NewOrderSingle.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case Fields.CustomTags.NoOrderAttributes: return new NewOrderSingle.NoOrderAttributesGroup();
                        case Fields.CustomTags.NoLinks: return new NewOrderSingle.NoLinksGroup();
                    }
                }

                if (MultilegOrderCancelReplace.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoSecurityAltID: return new MultilegOrderCancelReplace.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoLegs: return new MultilegOrderCancelReplace.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new MultilegOrderCancelReplace.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case Fields.CustomTags.NoStrategyParameters: return new MultilegOrderCancelReplace.NoStrategyParametersGroup();
                        case Fields.CustomTags.NoPartyIDs: return new MultilegOrderCancelReplace.NoPartyIDsGroup();
                        case Fields.CustomTags.NoOrderAttributes: return new MultilegOrderCancelReplace.NoOrderAttributesGroup();
                        case Fields.CustomTags.NoLinks: return new MultilegOrderCancelReplace.NoLinksGroup();
                    }
                }

                if (OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoSecurityAltID: return new OrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoStrategyParameters: return new OrderCancelReplaceRequest.NoStrategyParametersGroup();
                        case Fields.CustomTags.NoPartyIDs: return new OrderCancelReplaceRequest.NoPartyIDsGroup();
                        case Fields.CustomTags.NoOrderAttributes: return new OrderCancelReplaceRequest.NoOrderAttributesGroup();
                        case Fields.CustomTags.NoLinks: return new OrderCancelReplaceRequest.NoLinksGroup();
                        case Fields.CustomTags.NoLegs: return new OrderCancelReplaceRequest.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new OrderCancelReplaceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoSecurityAltID: return new OrderCancelRequest.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoLegs: return new OrderCancelRequest.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new OrderCancelRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case Fields.CustomTags.NoPartyIDs: return new OrderCancelRequest.NoPartyIDsGroup();
                        case Fields.CustomTags.NoOrderAttributes: return new OrderCancelRequest.NoOrderAttributesGroup();
                        case Fields.CustomTags.NoLinks: return new OrderCancelRequest.NoLinksGroup();
                    }
                }

                if (SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoSecurityAltID: return new SecurityDefinition.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoEvents: return new SecurityDefinition.NoEventsGroup();
                        case Fields.CustomTags.NumTickTblEntries: return new SecurityDefinition.NumTickTblEntriesGroup();
                        case Fields.CustomTags.NoLegs: return new SecurityDefinition.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new SecurityDefinition.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (SecurityStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoSecurityAltID: return new SecurityStatusRequest.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoLegs: return new SecurityStatusRequest.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new SecurityStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoMDEntryTypes: return new MarketDataRequest.NoMDEntryTypesGroup();
                        case Fields.CustomTags.NoRelatedSym: return new MarketDataRequest.NoRelatedSymGroup();
                        case Fields.CustomTags.NoSecurityAltID: return new MarketDataRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoLegs: return new MarketDataRequest.NoRelatedSymGroup.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new MarketDataRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (MarketDataSnapshot.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoMDEntries: return new MarketDataSnapshot.NoMDEntriesGroup();
                    }
                }

                if (MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoMDEntries: return new MarketDataIncrementalRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoRelatedSym: return new QuoteRequest.NoRelatedSymGroup();
                    }
                }

                if (TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoSecurityAltID: return new TradeCaptureReport.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoLegs: return new TradeCaptureReport.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new TradeCaptureReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                        case Fields.CustomTags.NoSides: return new TradeCaptureReport.NoSidesGroup();
                        case Fields.CustomTags.NoPartyIDs: return new TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
                        case Fields.CustomTags.NoTCRLegs: return new TradeCaptureReport.NoTCRLegsGroup();
                        //case Fields.CustomTags.NoSides: return new TradeCaptureReport.NoTCRLegsGroup.NoSidesGroup();
                    }
                }

                if (TradeCaptureReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoSecurityAltID: return new TradeCaptureReportAck.NoSecurityAltIDGroup();
                        case Fields.CustomTags.NoLegs: return new TradeCaptureReportAck.NoLegsGroup();
                        case Fields.CustomTags.NoLegSecurityAltID: return new TradeCaptureReportAck.NoLegsGroup.NoLegSecurityAltIDGroup();
                    }
                }

                if (OrderMassAction.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case Fields.CustomTags.NoAffectedOrders: return new OrderMassAction.NoAffectedOrdersGroup();
                    }
                }

                return null;
            }

        }
    }
}
