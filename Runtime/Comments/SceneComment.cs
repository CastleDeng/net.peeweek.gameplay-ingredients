﻿using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace GameplayIngredients.Comments
{
    public class SceneComment : MonoBehaviour
    {

#if UNITY_EDITOR

        const string kUserPreference = "GameplayIngredients.Comments.User";

        public bool UsePOV;
        public Comment comment => m_Comment;
        [SerializeField]
        Comment m_Comment;
        private void Reset()
        {
            m_Comment.message.from = EditorPrefs.GetString(kUserPreference, "user");
        }

#endif
    }
}