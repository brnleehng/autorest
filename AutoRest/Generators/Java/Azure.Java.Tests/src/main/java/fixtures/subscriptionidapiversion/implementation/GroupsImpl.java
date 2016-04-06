/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.subscriptionidapiversion.implementation;

import com.google.common.reflect.TypeToken;
import com.microsoft.azure.AzureServiceResponseBuilder;
import com.microsoft.rest.ServiceCall;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import com.microsoft.rest.ServiceResponseCallback;
import fixtures.subscriptionidapiversion.models.ErrorException;
import fixtures.subscriptionidapiversion.models.SampleResourceGroupImpl;
import java.io.IOException;
import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Header;
import retrofit2.http.Headers;
import retrofit2.http.Path;
import retrofit2.http.Query;
import retrofit2.Response;
import retrofit2.Retrofit;

/**
 * An instance of this class provides access to all the operations defined
 * in Groups.
 */
public final class GroupsImpl {
    /** The Retrofit service to perform REST calls. */
    private GroupsService service;
    /** The service client containing this operation class. */
    private MicrosoftAzureTestUrlImpl client;

    /**
     * Initializes an instance of GroupsImpl.
     *
     * @param retrofit the Retrofit instance built from a Retrofit Builder.
     * @param client the instance of the service client containing this operation class.
     */
    public GroupsImpl(Retrofit retrofit, MicrosoftAzureTestUrlImpl client) {
        this.service = retrofit.create(GroupsService.class);
        this.client = client;
    }

    /**
     * The interface defining all the services for Groups to be
     * used by Retrofit to perform actually REST calls.
     */
    interface GroupsService {
        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}")
        Call<ResponseBody> getSampleResourceGroup(@Path("subscriptionId") String subscriptionId, @Path("resourceGroupName") String resourceGroupName, @Query("api-version") String apiVersion, @Header("accept-language") String acceptLanguage);

    }

    /**
     * Provides a resouce group with name 'testgroup101' and location 'West US'.
     *
     * @param resourceGroupName Resource Group name 'testgroup101'.
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @throws IllegalArgumentException exception thrown from invalid parameters
     * @return the SampleResourceGroupImpl object wrapped in {@link ServiceResponse} if successful.
     */
    public ServiceResponse<SampleResourceGroupImpl> getSampleResourceGroup(String resourceGroupName) throws ErrorException, IOException, IllegalArgumentException {
        if (this.client.getSubscriptionId() == null) {
            throw new IllegalArgumentException("Parameter this.client.getSubscriptionId() is required and cannot be null.");
        }
        if (resourceGroupName == null) {
            throw new IllegalArgumentException("Parameter resourceGroupName is required and cannot be null.");
        }
        if (this.client.getApiVersion() == null) {
            throw new IllegalArgumentException("Parameter this.client.getApiVersion() is required and cannot be null.");
        }
        Call<ResponseBody> call = service.getSampleResourceGroup(this.client.getSubscriptionId(), resourceGroupName, this.client.getApiVersion(), this.client.getAcceptLanguage());
        return getSampleResourceGroupDelegate(call.execute());
    }

    /**
     * Provides a resouce group with name 'testgroup101' and location 'West US'.
     *
     * @param resourceGroupName Resource Group name 'testgroup101'.
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if callback is null
     * @return the {@link Call} object
     */
    public ServiceCall getSampleResourceGroupAsync(String resourceGroupName, final ServiceCallback<SampleResourceGroupImpl> serviceCallback) throws IllegalArgumentException {
        if (serviceCallback == null) {
            throw new IllegalArgumentException("ServiceCallback is required for async calls.");
        }
        if (this.client.getSubscriptionId() == null) {
            serviceCallback.failure(new IllegalArgumentException("Parameter this.client.getSubscriptionId() is required and cannot be null."));
            return null;
        }
        if (resourceGroupName == null) {
            serviceCallback.failure(new IllegalArgumentException("Parameter resourceGroupName is required and cannot be null."));
            return null;
        }
        if (this.client.getApiVersion() == null) {
            serviceCallback.failure(new IllegalArgumentException("Parameter this.client.getApiVersion() is required and cannot be null."));
            return null;
        }
        Call<ResponseBody> call = service.getSampleResourceGroup(this.client.getSubscriptionId(), resourceGroupName, this.client.getApiVersion(), this.client.getAcceptLanguage());
        final ServiceCall serviceCall = new ServiceCall(call);
        call.enqueue(new ServiceResponseCallback<SampleResourceGroupImpl>(serviceCallback) {
            @Override
            public void onResponse(Call<ResponseBody> call, Response<ResponseBody> response) {
                try {
                    serviceCallback.success(getSampleResourceGroupDelegate(response));
                } catch (ErrorException | IOException exception) {
                    serviceCallback.failure(exception);
                }
            }
        });
        return serviceCall;
    }

    private ServiceResponse<SampleResourceGroupImpl> getSampleResourceGroupDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return new AzureServiceResponseBuilder<SampleResourceGroupImpl, ErrorException>(this.client.getMapperAdapter())
                .register(200, new TypeToken<SampleResourceGroupImpl>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

}
