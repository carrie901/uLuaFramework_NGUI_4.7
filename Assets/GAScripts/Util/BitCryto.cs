using System.Collections;

public class BitCryto
{

    private short[] crytoKey;
    private int offsetOfKey;

    public BitCryto(short[] sKey)
    {
        crytoKey = sKey;
        offsetOfKey = 0;
    }

    /// <summary>
    /// 加密
    /// </summary>
    public byte Encode(byte inputByte)
    {
        if (offsetOfKey >= crytoKey.Length) offsetOfKey = 0;

        short offset = (short)crytoKey[offsetOfKey++];
        short outputByte = (short)((short)inputByte - offset);
        if (outputByte < 0) outputByte += 256;
        return (byte)outputByte;
    }

    /// <summary>
    /// 解密
    /// </summary>
    public byte Decode(byte value)
    {
        if (offsetOfKey >= crytoKey.Length) offsetOfKey = 0;

        short offset = crytoKey[offsetOfKey++];
        short result = (short)((short)value + offset);
        if (result >= 256) result -= 256;
        return (byte)(result);
    }

    public void Reset()
    {
        offsetOfKey = 0;
    }

}
