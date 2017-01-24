/*
 * Author: Isaiah Mann
 * Description: Unity independent setup for a timer
 */

public interface IGameTimer 
{
	#region Instance Accessors 

	bool TimeIsUp 
	{
		get;
	}

	bool IsRunning 
	{
		get;
	}

	float TimeRemaining 
	{
		get;
	}

	#endregion

	IGameTimer Setup(float timeStep, float maxTime);

	void Teardown();
	void Reset();
	void Begin(bool resetOnStart);
	void Resume();

	float Pause();
	float Stop(bool resetOnStop);

  void SubscribeToTimeChange(DataObject.DataActionf action);
  void UnsubscribeFromTimeChange(DataObject.DataActionf action);
  void SubscribeToTimeUp(DataObject.DataAction action);
  void UnsubscribeFromTimeUp(DataObject.DataAction action);
  void ClearEventsOnTimeUp();
	void ModifyTimeRemaining(float deltaTime, bool checkForEvents);
	void SetTimeRemaining(float newTime, bool checkForEvents);
	void ZeroOutTimeRemaining(bool shouldCallTimeUpEvent);

}
