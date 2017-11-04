using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;


public class HandDirectionGetter : MonoBehaviour {
    public static Vector3 getHandDirection(string handSide) {
        LeapServiceProvider provider = FindObjectOfType<LeapServiceProvider>() as LeapServiceProvider;
        Controller controller = provider.GetLeapController();
        Frame frame = controller.Frame();
        Hand savedHand = null;

        if (frame.Hands.Count > 0) {
            List<Hand> hands = frame.Hands;
            foreach (Hand hand in hands) {
                if (handSide == "Right" && hand.IsRight) savedHand = hand;
                else if (handSide == "Left" && hand.IsLeft) savedHand = hand;
            }
        }

        if (savedHand != null) {
            Vector3 realDirection = savedHand.Direction.ToVector3();
            realDirection = new Vector3(realDirection.x, realDirection.y, -realDirection.z);
            return realDirection;
        } else {
            return Vector3.zero;
        }
    }

    public static Vector3 GetPositionOfRightHand() {
        LeapProvider provider = FindObjectOfType<LeapProvider>() as LeapProvider;
        Frame frame;
        frame = provider.CurrentFrame;
        Hand savedHand = null;

        if (frame.Hands.Count > 0) {
            System.Collections.Generic.List<Hand> hands = frame.Hands;
            foreach (Hand hand in hands) {
                if (hand.IsRight) savedHand = hand;
            }
        }

        if (savedHand == null) {
            return Vector3.zero;
        } else {
            return savedHand.PalmPosition.ToVector3();
        }

        
    }

    public static Vector3 GetPositionOfRightHand2() {
        LeapServiceProvider provider = FindObjectOfType<LeapServiceProvider>() as LeapServiceProvider;
        Controller controller = provider.GetLeapController();
        Frame frame;
        frame = controller.Frame();
        Hand savedHand = null;

        if (frame.Hands.Count > 0) {
            List<Hand> hands = frame.Hands;
            foreach (Hand hand in hands) {
                if (hand.IsRight) savedHand = hand;
            }
        }

        return savedHand.PalmPosition.ToVector3();
    }
}