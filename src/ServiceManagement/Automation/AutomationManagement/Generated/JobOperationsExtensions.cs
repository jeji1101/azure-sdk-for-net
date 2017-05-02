// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Automation;
using Microsoft.WindowsAzure.Management.Automation.Models;

namespace Microsoft.WindowsAzure.Management.Automation
{
    public static partial class JobOperationsExtensions
    {
        /// <summary>
        /// Create a job of the runbook.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create job operation.
        /// </param>
        /// <returns>
        /// The response model for the create job operation.
        /// </returns>
        public static JobCreateResponse Create(this IJobOperations operations, string automationAccount, JobCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).CreateAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a job of the runbook.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create job operation.
        /// </param>
        /// <returns>
        /// The response model for the create job operation.
        /// </returns>
        public static Task<JobCreateResponse> CreateAsync(this IJobOperations operations, string automationAccount, JobCreateParameters parameters)
        {
            return operations.CreateAsync(automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the job identified by job id.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// The response model for the get job operation.
        /// </returns>
        public static JobGetResponse Get(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).GetAsync(automationAccount, jobId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the job identified by job id.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// The response model for the get job operation.
        /// </returns>
        public static Task<JobGetResponse> GetAsync(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return operations.GetAsync(automationAccount, jobId, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the job output identified by job id.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// The response model for the get job output operation.
        /// </returns>
        public static JobGetOutputResponse GetOutput(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).GetOutputAsync(automationAccount, jobId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the job output identified by job id.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// The response model for the get job output operation.
        /// </returns>
        public static Task<JobGetOutputResponse> GetOutputAsync(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return operations.GetOutputAsync(automationAccount, jobId, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the runbook content of the job identified by job id.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// The response model for the get runbook content of the job operation.
        /// </returns>
        public static JobGetRunbookContentResponse GetRunbookContent(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).GetRunbookContentAsync(automationAccount, jobId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the runbook content of the job identified by job id.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// The response model for the get runbook content of the job operation.
        /// </returns>
        public static Task<JobGetRunbookContentResponse> GetRunbookContentAsync(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return operations.GetRunbookContentAsync(automationAccount, jobId, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of jobs.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters supplied to the list operation.
        /// </param>
        /// <returns>
        /// The response model for the list job operation.
        /// </returns>
        public static JobListResponse List(this IJobOperations operations, string automationAccount, JobListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).ListAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of jobs.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters supplied to the list operation.
        /// </param>
        /// <returns>
        /// The response model for the list job operation.
        /// </returns>
        public static Task<JobListResponse> ListAsync(this IJobOperations operations, string automationAccount, JobListParameters parameters)
        {
            return operations.ListAsync(automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of jobs.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list job operation.
        /// </returns>
        public static JobListResponse ListNext(this IJobOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of jobs.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list job operation.
        /// </returns>
        public static Task<JobListResponse> ListNextAsync(this IJobOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Resume the job identified by jobId.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Resume(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).ResumeAsync(automationAccount, jobId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Resume the job identified by jobId.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> ResumeAsync(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return operations.ResumeAsync(automationAccount, jobId, CancellationToken.None);
        }
        
        /// <summary>
        /// Stop the job identified by jobId.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Stop(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).StopAsync(automationAccount, jobId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Stop the job identified by jobId.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> StopAsync(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return operations.StopAsync(automationAccount, jobId, CancellationToken.None);
        }
        
        /// <summary>
        /// Suspend the job identified by jobId.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Suspend(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).SuspendAsync(automationAccount, jobId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Suspend the job identified by jobId.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> SuspendAsync(this IJobOperations operations, string automationAccount, Guid jobId)
        {
            return operations.SuspendAsync(automationAccount, jobId, CancellationToken.None);
        }
    }
}