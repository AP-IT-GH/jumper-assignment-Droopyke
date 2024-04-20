* Set-up: Open the RoanTestScene or use the 'ML Jumper' prefab in your own scene.
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
![image](https://github.com/AP-IT-GH/jumper-assignment-YR/assets/102216533/2b5fec6c-8131-458b-999d-129973e14ebc)
In the image above you can see the Agent his training after adding the gold coin. Here he trains slower and has also some ups and downs during his training. 

Conclusion:

The randomness coorelates with the speed of learning for the ML Agent.
When we introduced randomly speeded blocks that the ML agent had to jump over, we saw the learning time increased.

Whenever we introduced the bonus objects (coins), the ML agent could not establish the difference between both the bonus and non-bonus coins. We had to add an observation manually.

The conclusion is, making it impossible for the ML agent to be able to establish things will make it not be able to learn.

