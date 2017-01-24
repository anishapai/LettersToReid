/*
 * Author: Isaiah Mann
 * Description: Abstract data class
 */

using k = Global;

[System.Serializable]
public abstract class SerializableData 
{
  protected const string TIME_STAMP = k.TIME_STAMP;
    
	const float FULL_PERCENT = k.FULL_PERCENT;

	protected float percentToDecimal(int percent)
	{
		return percentToDecimal((float) percent);
	}

	protected float percentToDecimal(float percent)
	{
		return percent / FULL_PERCENT;
	}

}
