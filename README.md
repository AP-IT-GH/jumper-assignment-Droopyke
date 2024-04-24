# Introduction
The goal of this task was to find a way to make an ML Agent jump over a series of blocks.<br>
One of these blocks should give bonus points whilst the others need to be avoided and jumped over.

We approached this goal by thinking logically, would it be possible for the ML Agent to learn this?
 
# Training it yourself
You'll need:
* protobuf==3.20.*
* torch~=1.7.1
* mlagents==0.30.0

```
pip3 install protobuf==3.20.*
pip3 install torch~=1.7.1 -f https://download.pytorch.org/whl/torch_stable.html
python -m pip install mlagents==0.30.0
```

Then head to the assets file in the project, and run:
```
mlagents-learn config/CubeAgent.yaml --run-id=CubeAgent
```

# Environment
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

# Training

We started by training the agent, only by having it jump over a block. <br>
The agent would be able to see this by using the 3D perception rays that Unity provides.

![image](https://github.com/AP-IT-GH/jumper-assignment-YR/assets/102216533/89264809-5202-4ca2-911f-12f20120b84e)
As you can see, the result of the first training. <br>
In this image we trained the agent before we introduced the coins.

We then decided to introduce one extra part: Speed randomness and bonus coins. <br>
We then trained the model again.

But we quickly turned into an issue: The agent could not figure out which object was a bonus coin, and which one was a block. <br>
So we introduced a new observation: the type of object heading to the ML agent.

![image](https://github.com/AP-IT-GH/jumper-assignment-YR/assets/102216533/2b5fec6c-8131-458b-999d-129973e14ebc)
In the image above, it took longer for the agent to train. The randomness and extra difficulty caused this.

# Conclusion

The randomness coorelates with the speed of learning for the ML Agent.
When we introduced randomly speeded blocks that the ML agent had to jump over, we saw the learning time increased.

Whenever we introduced the bonus objects (coins), the ML agent could not establish the difference between both the bonus and non-bonus coins. We had to add an observation manually.

The conclusion is, making it impossible for the ML agent to be able to establish things will make it not be able to learn.
