using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Requests;
using TestApp.Responses;

namespace TestApp
{
    [Produces("application/json")]
    [ApiController, Route("BusinessService/[controller]")]
    public class UserController : ControllerBase
    {
        public UserController(/*your code here if it needs*/)
        {
            /*add your code here if it needs*/
            
            /*Main condition - you cannot resolve UserStoreDbContext directly by DI, you should use IServiceScopeFactory*/
            /*You can use Automapper/Master here if it needs, but you also cannot resolve it in the Constructor by DI, you should use IServiceScopeFactory*/
        }

        //This method should be called on ../User/{Id}/GetUserInfo, where Id - standard System.Guid type
        public async Task<ActionResult<UserInfoResponse>> GetUserInfo(Guid Id)
        {
            /*your code here*/

            return null; //Change null to the generated UserInfoResponse object 
        }

        //This method should be called on ../User/{Id}/GetUserInfo, where Id - standard System.Guid type
        public async Task<ActionResult<UserProfileResponse>> GetUserProfile(Guid Id)
        {
            /*your code here*/

            return null; //Change null to the generated UserInfoResponse object 
        }

        //This method should be called on ../User/{Id}/GetUserProfilesById, where Id - standard System.Guid type
        public async Task<ActionResult<UserProfileCollectionResponse>> GetUserProfilesById(Guid Id, IdCollectionRequest request) 
        {
            /*your code here*/

            return null; //Change null to the generated UserInfoResponse object 
        }

        //This method should be called on ../User/{Id}/GetActiveUserProfiles, where Id - standard System.Guid type
        public async Task<ActionResult<UserProfileCollectionResponse>> GetActiveUserProfiles(Guid Id) //filter by IsActive field
        {
            /*your code here*/

            return null; //Change null to the generated UserInfoResponse object 
        }

        //This method should be called on ../User/{Id}/GetUserProfilesByRole, where Id - standard System.Guid type
        public async Task<ActionResult<UserProfileCollectionResponse>> GetUserProfilesByRole(Guid Id, RoleRequest request)
        {
            /*your code here*/

            return null; //Change null to the generated UserInfoResponse object 
        }
    }
}
