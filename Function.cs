using CloudNative.CloudEvents;
using Google.Cloud.Functions.Framework;
using Google.Events.Protobuf.Cloud.Storage.V1;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StorageSample
{
    public class Function : ICloudEventFunction<StorageObjectData>
    {
        public Task HandleAsync(CloudEvent cloudEvent, StorageObjectData data, CancellationToken cancellationToken)
        {
            Console.WriteLine($"CloudEvent type: {cloudEvent.Type}");
            Console.WriteLine($"Storage bucket: {data.Bucket}");
            Console.WriteLine($"Storage object name: {data.Name}");
            return Task.CompletedTask;
        }
    }
}
