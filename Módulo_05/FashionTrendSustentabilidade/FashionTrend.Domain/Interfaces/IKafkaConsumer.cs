public interface IKafkaConsumer
{
    public Task StartConsumingAsync(CancellationToken cancellationToken);
    public void StopConsuming();
    public void Subscribe(string topic, string group);

    event EventHandler<MessageReceivedEventArgs> OnMessageReceived;
}