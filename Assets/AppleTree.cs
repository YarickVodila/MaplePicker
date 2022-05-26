using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    //Prefab для создания яблок
    public GameObject applePrefab;
    //Скорость движения яблок
    public float speed = 10f;
    //Расстояние от края на котором меняется направление яблони
	public float leftAndRightEdge = 10f;
    //Вероятность изменения направления движения
    public float chanceToChangeDirections = 0.1f;
    //Скорость создания яблок
    public float secondsBetweenAppleDrops = 1f;
	ChangePhoto change = new ChangePhoto();
	
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
		
		int value = Random.Range(0, 1);
		
		
    }


    // Update is called once per frame
    void Update()
    {
  //локальная переменная для хранения текущий позиции AppleTree
        Vector3 pos = transform.position;
//компонент x увеличивается на произведение скорости и временного интервала
        pos.x += speed * Time.deltaTime;
//изменение переменной pos записывается обратно в transform.position
        transform.position = pos;
//если значение pos.x оказалось меньше значения leftAndRightEdge - переменной speed  присваивается ее положительное значение и тем самым обеспечивается движение вправо в следующем кадре
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
//иначе если значение pos.x оказалось больше значения leftAndRightEdge - переменной speed  присваивается ее отрицательное значение и тем самым обеспечивается движение влево в следующем кадре
        } else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        } 
    }
	private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
	

}



