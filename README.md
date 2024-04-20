* Set-up: Place the 'Barry' prefab into the scene with a platform for him to stand on.
* Goal: The agent must jump over the red blocks (Mushrooms) and collect the gold coins.
* Agents: The environment contains one agent linked to one Model.
* Agent Reward Function:
  * -1.0 if the agent doesn't touch the coin.
  * +1.0 if the agent touches the coin.
  * -1.0 if the agent touches the mushroom.
  * +1.0 if the agent doesn't touch the mushroom.
* Behavior Parameters:
  * Vector Observation space: Size of 3, corresponding to 7 ray casts.
  * Actions:
    * Jump (2 possible actions: Jump, No Action)
  * Config:
      CubeAgent.yaml: (https://github.com/AP-IT-GH/jumper-assignment-YR/blob/0e591ff06ff6af7714df26d152a43dd3ea3b9993/Assets/config/CubeAgent.yaml)
    
![image](https://github.com/AP-IT-GH/jumper-assignment-YR/assets/102216533/89264809-5202-4ca2-911f-12f20120b84e)
In the image above you can see the Agent his training before adding the gold coin. The Agent trained very fast without the gold coin and knew what to do in no time. 

