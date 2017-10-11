using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackEventListener : IListener{

	void ReceiveAttackEvent(AttackEvent ae);
}
