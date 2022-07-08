/**
* @file ImageUIController.cs
* @brief UI.Imageで利用する画像を変えるクラス//
* @author 山内 悠佑
* @date 2022/07/07
* @details TextureManagerを経由してSpriteの画像を変更する
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @brief Spriteの画像を変えるクラス
* @details Canvasの子オブジェクトとして存在するSpriteを持つオブジェクトの画像をTextureManagerに登録されている画像に変更するクラス
*/
public class ImageUIController : MonoBehaviour
{

    //! ImageUIControllerが操作するSpriteを持つオブジェクト//
    [SerializeField]
    UnityEngine.UI.Image targetImageObject = null;

    //! 画像を取得するときに参照するTextureManagerオブジェクト//
    [SerializeField]
    TextureManager manager = null;

    /**
    * @fn public void SetTexture(in int _no)
    * @param[in] int(_no) 利用する画像の番号
    * @details TextureManagerから対象の画像を取得してSpriteにセットする。
    */
    public void SetTexture(int _no)
    {
        if (manager == null) return;
        if (targetImageObject == null) return;

        Texture2D tex = manager.GetTexture(_no);

        if (tex == null) return;

        targetImageObject.sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), Vector2.zero);
    }

    /**
    * @fn public void SetImageObject(in UnityEngine.UI.Image _imageObject)
    * @param[in] UnityEngine.UI.Image(_imageObject) 操作するSpriteを持つImageオブジェクト
    * @details 操作対象となるSpriteを持つUnityEngine.UI.Imageオブジェクトを実行中に変更する。
    */
    public void SetImageObject(in UnityEngine.UI.Image _imageObject)
    {
        if (_imageObject == null) return;

        targetImageObject = _imageObject;
    }

    /**
    * @fn public void SetTextureManager(in TextureManager _manager)
    * @param[in] TextureManager(_manager) 参照をしに行くTextureManagerオブジェクト
    * @details 参照しに行くTextureManagerを実行中に変更する。
    */
    public void SetTextureManager(in TextureManager _manager)
    {
        if (_manager == null) return;

        manager = _manager;
    }

}
