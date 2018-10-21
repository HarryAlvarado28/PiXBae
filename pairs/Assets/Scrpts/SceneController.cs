using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    public const int gridRows = 2;
    public const int gridCols = 6;
    public const float offSetX = 3.1f;
    public const float offSetY = 5.5f;
    public static int glob=0;

    [SerializeField] private MainCard originalCard;
    [SerializeField] private Sprite[] images;

    private void Start()
    {
        Vector3 startPos = originalCard.transform.position;
        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5 ,5 };
        numbers = ShuffleArray(numbers);
        for (int i = 0; i < gridCols; i++){
            for (int j = 0; j < gridRows; j++){
                MainCard card;
                if(i==0 && j==0){
                    card = originalCard;
                }
                else{
                    card = Instantiate(originalCard) as MainCard;
                }

                int index = j * gridCols + i;
                int id = numbers[index];
                glob = id;
                card.ChangeSprite(id, images[id]);

                float posX = (offSetX * i) + startPos.x;
                float posY = (offSetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);

             }
        }
    }
    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;

        }
        return newArray;
    }
    

    private MainCard _firstRevealed;
    private MainCard _secondReveal;

    private int _score = 0;
    [SerializeField] private TextMesh scoreLabel1;

    public bool caReveal{
        get { return _secondReveal == null; }
    }

    public void CardRevealed(MainCard card){
        if (_firstRevealed == null)
        {
            _firstRevealed = card;
        }

        else
        {
            _secondReveal = card;
            StartCoroutine(CheckMatch());
        }
    }

    private IEnumerator CheckMatch()
    {
        if (_firstRevealed.id == _secondReveal.id)
        {
            _score++;
            scoreLabel1.text = "Score:" + _score;
            //De aqui empiez mi mod
            if (_secondReveal.id == 0)
            {
                Inform0.show();
                yield return new WaitForSeconds(3);
                Inform0.cerrar();
            }
            if (_secondReveal.id == 1)
            {
                Inform1.show();
                yield return new WaitForSeconds(3);
                Inform1.cerrar();
            }
            if (_secondReveal.id == 2)
            {
                Inform2.show();
                yield return new WaitForSeconds(3);
                Inform2.cerrar();
            }
            if (_secondReveal.id == 3)
            {
                Inform3.show();
                yield return new WaitForSeconds(3);
                Inform3.cerrar();
            }
            if (_secondReveal.id == 4)
            {
                Inform4.show();
                yield return new WaitForSeconds(3);
                Inform4.cerrar();
            }
            if (_secondReveal.id == 5)
            {
                Inform5.show();
                yield return new WaitForSeconds(3);
                Inform5.cerrar();
            }
            //aqui termina mi mod

        }

        else
        {
            yield return new WaitForSeconds(0.5f);

            _firstRevealed.Unrevealed();
            _secondReveal.Unrevealed();

        }

        _secondReveal = null;
        _firstRevealed = null;
    }
}
