using FlySharp.Http;
using FlySharp.Http.Did.Request;
using FlySharp.Http.Did.Response;

namespace FlySharp.Client.Abstract;

public interface IDidClient : IBaseClient
{
    #region DIDS
    Task<DidMutationResponse> AddDidAsync(AddDidRequest request);
    Task<DidMutationResponse> UpdateDidAsync(UpdateDidRequest request);
    Task<BaseResponse> DeleteDidByIdAsync(int didId);
    Task<BaseResponse> DeleteDidByNumberAsync(string did);
    Task<GetDidInfoResponse> GetDidByIdAsync(int didId);
    Task<GetDidInfoResponse> GetDidByNumberAsync(string did);
    Task<GetDidsListResponse> GetDidsAsync(GetDidsListRequest request);
    #endregion

    #region CHARGING_GROUPS
    Task<GetDidChargingGroupInfoResponse> GetDidChargingGroupInfoAsync(int chargingGroupId);
    #endregion

    #region DELEGATIONS
    Task<DidDelegationMutationResponse> AddDidDelegationAsync(AddDidDelegationRequest request);
    Task<DidDelegationMutationResponse> UpdateDidDelegationAsync(UpdateDidDelegationRequest request);
    Task<BaseResponse> DeleteDidDelegationAsync(int delegationId);
    #endregion
}
