using System;
//using Firebase.Auth;
using TMPro;
using UnityEngine;

public class AtomCollector : MonoBehaviour
{
    public TMP_Text cText;
    public TMP_Text oText;
    public TMP_Text hText;
    public TMP_Text nText;
    public TMP_Text clText;
    public TMP_Text naText;
    public TMP_Text mgText;
    public TMP_Text sText;

    private int c;
    private int o;
    private int h;
    private int n;
    private int cl;
    private int na;
    private int mg;
    private int s;

   // private FirebaseAuthManager _firebaseAuthManager;

    private void Awake()
    {
        //_firebaseAuthManager = new FirebaseAuthManager();
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.GetComponent<Atom>().GetAtomType())
        {
            case AtomType.C:
                c++;
                //_ = _firebaseAuthManager.IncrementAtomAsync(c.ToString());
                cText.text = c.ToString();
                break;
            case AtomType.O:
                o++;
                //_ = _firebaseAuthManager.IncrementAtomAsync(o.ToString());
                oText.text = o.ToString();
                break;
            case AtomType.H:
                h++;
                //_ = _firebaseAuthManager.IncrementAtomAsync(h.ToString());
                hText.text = h.ToString();
                break;
            case AtomType.N:
                n++;
                //_ = _firebaseAuthManager.IncrementAtomAsync(n.ToString());
                nText.text = n.ToString();
                break;
            case AtomType.Cl:
                cl++;
                //_ = _firebaseAuthManager.IncrementAtomAsync(cl.ToString());
                clText.text = cl.ToString();
                break;
            case AtomType.Na:
                na++;
                //_ = _firebaseAuthManager.IncrementAtomAsync(na.ToString());
                naText.text = na.ToString();
                break;
            case AtomType.Mg:
                mg++;
                //_ = _firebaseAuthManager.IncrementAtomAsync(mg.ToString());
                mgText.text = mg.ToString();
                break;
            case AtomType.S:
                s++;
                //_ = _firebaseAuthManager.IncrementAtomAsync(s.ToString());
                sText.text = s.ToString();
                break;
        }

        Destroy(other.gameObject);
    }
}
public enum AtomType
{
    H,
    O,
    C,
    N,
    Cl,
    Na,
    Mg,
    S,
}