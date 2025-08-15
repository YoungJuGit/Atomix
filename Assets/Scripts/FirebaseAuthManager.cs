using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
// using Firebase;
// using Firebase.Extensions;
// using Firebase.Auth;
// using Firebase.Firestore;
using TMPro;
using UnityEngine;

public class FirebaseAuthManager : MonoBehaviour
{
    private static FirebaseAuthManager _instance = null;

    // private FirebaseAuth _auth;
    // private FirebaseUser _user;

    //private FirebaseFirestore _firestore;

    // [SerializeField] private TMP_InputField _emailInputField;
    //
    // [SerializeField] private TMP_InputField _passwordInputField;

    private string _deviceId;
    // Start is called before the first frame update
    public static FirebaseAuthManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("FirebaseAuthManager Instance does not exist in the scene!");
            }
            return _instance;
        }
    }
    private void Awake()
    {
        // 싱글턴 패턴 구현 (중복 방지)
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject); // 이미 인스턴스가 존재하면 현재 오브젝트를 제거
            return;
        }
        
        _instance = this;
        DontDestroyOnLoad(gameObject); // 씬이 전환되어도 오브젝트 유지
    }
   
    void Start()
    {
        // _auth = FirebaseAuth.DefaultInstance;
       // _firestore = FirebaseFirestore.DefaultInstance;
        _deviceId = SystemInfo.deviceUniqueIdentifier;
    }

    // public void SignUp()
    // {
    //     _auth.CreateUserWithEmailAndPasswordAsync(_emailInputField.text, _passwordInputField.text).ContinueWith(
    //         task =>
    //         {
    //             if (task.IsCanceled)
    //             {
    //                 Debug.Log("Sign up cancelled");
    //                 return;
    //             }
    //
    //             if (task.IsFaulted)
    //             {
    //                 Debug.Log("Sign up failed");
    //                 return;
    //             }
    //
    //             var user = task.Result;
    //             Debug.Log("Sign up completed");
    //         });
    // }
    //
    // public void Login()
    // {
    //     bool isSuccess = false;
    //     _auth.SignInWithEmailAndPasswordAsync(_emailInputField.text, _passwordInputField.text).ContinueWithOnMainThread(
    //         task =>
    //         {
    //             if (task.IsCanceled || task.IsFaulted)
    //             {
    //                 Debug.Log("Login failed");
    //                 StartCoroutine(LoginCoroutine(isSuccess));
    //                 return;
    //             }
    //
    //             if (task.IsCompleted)
    //             {
    //                 isSuccess = true;
    //                 StartCoroutine(LoginCoroutine(isSuccess));
    //                 Debug.Log("Login completed");
    //             }
    //         });
    // }
  
    public async Task IncrementAtomAsync(string key, int delta = 1)
    {
        Debug.Log("@@@1");
        // "users" 컬렉션의 특정 문서를 참조합니다.
       // DocumentReference userRef = _firestore.Collection("users").Document("_deviceId");

        Debug.Log("@@@2");
        // Firestore에서 "atoms" 필드의 특정 키 값을 증가시킵니다.
        Dictionary<string, object> updates = new Dictionary<string, object>
        {
        //    { $"atoms.{key}", FieldValue.Increment(delta) }
        };
        Debug.Log("@@@3");

      //  try
      //  {
       //     await userRef.UpdateAsync(updates);
            UnityEngine.Debug.Log($"Successfully updated atom: {key} by {delta}");
        }
       // catch (FirebaseException e)
      //  {
       //     UnityEngine.Debug.LogError($"Failed to update atom: {e.Message}");
      //  }
    }
    // public void UploadData(string collectionName, string documentId , string data)
    // {
    //     _firestore.Collection(collectionName).Document(documentId).SetAsync(data).ContinueWith(
    //         task =>
    //         {
    //             
    //         });
    // }
//}