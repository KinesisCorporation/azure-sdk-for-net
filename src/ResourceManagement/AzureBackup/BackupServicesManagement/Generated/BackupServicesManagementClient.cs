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
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.BackupServices;

namespace Microsoft.Azure.Management.BackupServices
{
    public partial class BackupServicesManagementClient : ServiceClient<BackupServicesManagementClient>, IBackupServicesManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private string _resourceGroupName;
        
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }
        
        private string _resourceName;
        
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }
        
        private IBackUpOperations _backUp;
        
        /// <summary>
        /// Definition of BackUp operations for the Azure Backup extension.
        /// </summary>
        public virtual IBackUpOperations BackUp
        {
            get { return this._backUp; }
        }
        
        private IContainerOperation _container;
        
        /// <summary>
        /// Definition of Container operations for the Azure Backup extension.
        /// </summary>
        public virtual IContainerOperation Container
        {
            get { return this._container; }
        }
        
        private ICSMProtectionPolicyOperations _cSMProtectionPolicy;
        
        /// <summary>
        /// Definition of Protection Policy operations for the Azure Backup
        /// extension.
        /// </summary>
        public virtual ICSMProtectionPolicyOperations CSMProtectionPolicy
        {
            get { return this._cSMProtectionPolicy; }
        }
        
        private IDataSourceOperations _dataSource;
        
        /// <summary>
        /// Definition of DataSource operations for the Azure Backup extension.
        /// </summary>
        public virtual IDataSourceOperations DataSource
        {
            get { return this._dataSource; }
        }
        
        private IJobOperations _job;
        
        /// <summary>
        /// Definition of Job operations for Azure backup extension.
        /// </summary>
        public virtual IJobOperations Job
        {
            get { return this._job; }
        }
        
        private IOperationStatus _operationStatus;
        
        /// <summary>
        /// Definition of Workflow operation for the Azure Backup extension.
        /// </summary>
        public virtual IOperationStatus OperationStatus
        {
            get { return this._operationStatus; }
        }
        
        private IProtectableObjectOperations _protectableObject;
        
        /// <summary>
        /// Definition of Protectable ObjectOperation operations for the Azure
        /// Backup extension.
        /// </summary>
        public virtual IProtectableObjectOperations ProtectableObject
        {
            get { return this._protectableObject; }
        }
        
        private IRecoveryPointOperations _recoveryPoint;
        
        /// <summary>
        /// Definition of Recovery Point operations for the Azure Backup
        /// extension.
        /// </summary>
        public virtual IRecoveryPointOperations RecoveryPoint
        {
            get { return this._recoveryPoint; }
        }
        
        private IRestoreOperations _restore;
        
        /// <summary>
        /// Definition of Restore operations for the Azure Backup extension.
        /// </summary>
        public virtual IRestoreOperations Restore
        {
            get { return this._restore; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BackupServicesManagementClient
        /// class.
        /// </summary>
        public BackupServicesManagementClient()
            : base()
        {
            this._backUp = new BackUpOperations(this);
            this._container = new ContainerOperation(this);
            this._cSMProtectionPolicy = new CSMProtectionPolicyOperations(this);
            this._dataSource = new DataSourceOperations(this);
            this._job = new JobOperations(this);
            this._operationStatus = new OperationStatus(this);
            this._protectableObject = new ProtectableObjectOperations(this);
            this._recoveryPoint = new RecoveryPointOperations(this);
            this._restore = new RestoreOperations(this);
            this._apiVersion = "2013-03-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the BackupServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public BackupServicesManagementClient(string resourceName, string resourceGroupName, SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._resourceName = resourceName;
            this._resourceGroupName = resourceGroupName;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the BackupServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public BackupServicesManagementClient(string resourceName, string resourceGroupName, SubscriptionCloudCredentials credentials)
            : this()
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._resourceName = resourceName;
            this._resourceGroupName = resourceGroupName;
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the BackupServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public BackupServicesManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._backUp = new BackUpOperations(this);
            this._container = new ContainerOperation(this);
            this._cSMProtectionPolicy = new CSMProtectionPolicyOperations(this);
            this._dataSource = new DataSourceOperations(this);
            this._job = new JobOperations(this);
            this._operationStatus = new OperationStatus(this);
            this._protectableObject = new ProtectableObjectOperations(this);
            this._recoveryPoint = new RecoveryPointOperations(this);
            this._restore = new RestoreOperations(this);
            this._apiVersion = "2013-03-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the BackupServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public BackupServicesManagementClient(string resourceName, string resourceGroupName, SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._resourceName = resourceName;
            this._resourceGroupName = resourceGroupName;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the BackupServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public BackupServicesManagementClient(string resourceName, string resourceGroupName, SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._resourceName = resourceName;
            this._resourceGroupName = resourceGroupName;
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// BackupServicesManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of BackupServicesManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<BackupServicesManagementClient> client)
        {
            base.Clone(client);
            
            if (client is BackupServicesManagementClient)
            {
                BackupServicesManagementClient clonedClient = ((BackupServicesManagementClient)client);
                
                clonedClient._resourceName = this._resourceName;
                clonedClient._resourceGroupName = this._resourceGroupName;
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}
