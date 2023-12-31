using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TriggerButtonScript2D : MonoBehaviour
{
    public GameObject canvas; // Ссылка на Canvas, на котором находится кнопка
    public Button button; // Ссылка на кнопку, которую вы хотите активировать

    public string sceneToLoad; // Название сцены, на которую нужно перейти
    public bool isMouseOver; // Флаг, показывающий, что курсор мыши находится внутри зоны триггера

    private void Start()
    {
       
        // Деактивируем кнопку и текст при старте сцены
        button.gameObject.SetActive(false);

    }

    /* // Метод вызывается, когда объект входит в триггер
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Проверяем, что объект, вошедший в триггер, имеет тег "Player"
        {
            // Активируем кнопку и текст
            button.gameObject.SetActive(true);


            // Добавляем обработчик события для кнопки (переход на другую сцену при клике)
            button.onClick.AddListener(LoadSceneOnClick);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Проверяем, что объект, вошедший в триггер, имеет тег "Player"
        {
            // Активируем кнопку и текст
            button.gameObject.SetActive(false);
        }
    } */
    private void Update()
    {
        if (isMouseOver && Input.GetMouseButtonDown(0))
        {
            // Активируем кнопку и текст
            button.gameObject.SetActive(true);

            // Добавляем обработчик события для кнопки (переход на другую сцену при клике)
            button.onClick.AddListener(LoadSceneOnClick);
        }
        
       
    }
    private void OnMouseEnter()
    {
        // Вызывается, когда курсор мыши входит в зону триггера
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        // Вызывается, когда курсор мыши покидает зону триггера
        isMouseOver = false;
    }


    // Метод для перехода на другую сцену при клике на кнопку
    private void LoadSceneOnClick()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}