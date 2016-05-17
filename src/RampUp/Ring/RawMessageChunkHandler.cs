namespace RampUp.Ring
{
    public delegate void RawMessageChunkHandler(ref RawMessageChunk chunk);

    public static class MessageHandlerExtensions
    {
        public static RawMessageChunkHandler ToRaw(this MessageHandler handler)
        {
            return (ref RawMessageChunk chunk) =>
            {
                var position = 0;
                while (RawMessageChunk.TryReadMessage(ref chunk, handler, ref position))
                {
                }
            };
        }
    }
}