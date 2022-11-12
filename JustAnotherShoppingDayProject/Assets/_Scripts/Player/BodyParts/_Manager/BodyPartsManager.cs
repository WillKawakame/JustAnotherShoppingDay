using System.Collections.Generic;
using UnityEngine;

public class BodyPartsManager : MonoBehaviour{
    public CharacterBody characterBody;
    public CharacterBody currentCharacterBody;

    protected Animator animator;
    protected AnimatorOverrideController animatorOverrideController;

    protected AnimationClipOverrides clipOverrides;
    public void Start()
    {
        animator = GetComponent<Animator>();

        animatorOverrideController = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = animatorOverrideController;

        clipOverrides = new AnimationClipOverrides(animatorOverrideController.overridesCount);
        animatorOverrideController.GetOverrides(clipOverrides);

        OverrideAnimations();
    }

    public void OverrideAnimations(){
        

        for (int partIndex = 0; partIndex < characterBody.BodyParts.Length; partIndex++){
            for(int itemAnimation = 0; itemAnimation < characterBody.BodyParts[partIndex].BodyPartItem.Animations.Length; itemAnimation++){
                clipOverrides[currentCharacterBody.BodyParts[partIndex].BodyPartItem.Animations[itemAnimation].name] = characterBody.BodyParts[partIndex].BodyPartItem.Animations[itemAnimation];
            }
        }
        
        animatorOverrideController.ApplyOverrides(clipOverrides);
    }
}

public class AnimationClipOverrides : List<KeyValuePair<AnimationClip, AnimationClip>>
{
    public AnimationClipOverrides(int capacity) : base(capacity) {}

    public AnimationClip this[string name]
    {
        get { return this.Find(x => x.Key.name.Equals(name)).Value; }
        set
        {
            int index = this.FindIndex(x => x.Key.name.Equals(name));
            if (index != -1)
                this[index] = new KeyValuePair<AnimationClip, AnimationClip>(this[index].Key, value);
        }
    }
}