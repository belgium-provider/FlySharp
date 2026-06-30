using FlySharp.Client.Abstract;
using FlySharp.Http;
using FlySharp.Http.Did.Request;
using FlySharp.Http.Did.Response;

namespace FlySharp.Client;

public class DidClient(FlySipOptions options, HttpClient? httpClient = null) : BaseClient(options, httpClient), IDidClient
{
    #region DIDS

    public async Task<DidMutationResponse> AddDidAsync(AddDidRequest request) => await this.CallAsync<DidMutationResponse>("addDID", request);

    public async Task<DidMutationResponse> UpdateDidAsync(UpdateDidRequest request) => await this.CallAsync<DidMutationResponse>("updateDID", request);

    public async Task<BaseResponse> DeleteDidByIdAsync(int didId) => await this.CallAsync<BaseResponse>("deleteDID", new { i_did = didId });

    public async Task<BaseResponse> DeleteDidByNumberAsync(string did) => await this.CallAsync<BaseResponse>("deleteDID", new { did });

    public async Task<GetDidInfoResponse> GetDidByIdAsync(int didId) => await this.CallAsync<GetDidInfoResponse>("getDIDInfo", new { i_did = didId });

    public async Task<GetDidInfoResponse> GetDidByNumberAsync(string did) => await this.CallAsync<GetDidInfoResponse>("getDIDInfo", new { did });

    public async Task<GetDidsListResponse> GetDidsAsync(GetDidsListRequest request) => await this.CallAsync<GetDidsListResponse>("getDIDsList", request);

    #endregion

    #region CHARGING_GROUPS

    public async Task<GetDidChargingGroupInfoResponse> GetDidChargingGroupInfoAsync(int chargingGroupId) => await this.CallAsync<GetDidChargingGroupInfoResponse>("getDIDChargingGroupInfo", new { i_dids_charging_group = chargingGroupId });

    #endregion

    #region DELEGATIONS

    public async Task<DidDelegationMutationResponse> AddDidDelegationAsync(AddDidDelegationRequest request) => await this.CallAsync<DidDelegationMutationResponse>("addDIDDelegation", request);

    public async Task<DidDelegationMutationResponse> UpdateDidDelegationAsync(UpdateDidDelegationRequest request) => await this.CallAsync<DidDelegationMutationResponse>("updateDIDDelegation", request);

    public async Task<BaseResponse> DeleteDidDelegationAsync(int delegationId) => await this.CallAsync<BaseResponse>("deleteDIDDelegation", new { i_did_delegation = delegationId });

    #endregion
}
