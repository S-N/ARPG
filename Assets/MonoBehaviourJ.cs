using UnityEngine;
using System.Collections;
/// <summary>
/// MonoBehaviour�̒�`�ς݊֐�����{��̐����Ƌ��ɋ�������Ă��܂��B
/// ���p����ɂ͂��̃t�@�C�����v���W�F�N�g�ɓ���AMonoBehaviour�̑���ɂ��̃N���X���p�����܂��B
/// �p����̃N���X��MonoBehaviour�̒�`�ς݊֐����Ē�`����ɂ�override�C���q�𖾎��I�ɕt����K�v������܂��B
/// Visual Studio���g�p����ۂɕ֗��Ȃ悤�ɍ���Ă��܂��B
/// </summary>
public abstract class MonoBehaviourJ : MonoBehaviour {
	/// <summary>
	/// ���t���[���Ăяo����܂��B
	/// </summary>
	public virtual void Update() {
	}

	/// <summary>
	/// ���t���[���Ăяo����܂��BUpdate������Ɏ��s����܂��B
	/// </summary>
	public virtual void LateUpdate() {
	}

	/// <summary>
	/// �t���[����荂�p�x�ȃt�B�b�N�X�h�t���[�����ƂɌĂяo����܂��B
	/// </summary>
	public virtual void FixedUpdate() {
	}

	/// <summary>
	/// �X�N���v�g�̃C���X�^���X�����[�h���ꂽ�Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void Awake() {
	}

	/// <summary>
	/// Update�֐����Ăяo����钼�O�ɂP�x�����Ăяo����܂��B
	/// </summary>
	public virtual void Start() {
	}

	/// <summary>
	/// �l���f�t�H���g�Ƀ��Z�b�g���܂��B
	/// </summary>
	public virtual void Reset() {
	}

	/// <summary>
	/// �}�E�X��GUIElement��Collider�ɓ������Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnMouseEnter() {
	}

	/// <summary>
	/// �}�E�X��GUIElement��Collider�̏�ɗ����Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnMouseOver() {
	}

	/// <summary>
	/// �}�E�X���AGUIElement��Collider����O�ɏo���Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnMouseExit() {
	}

	/// <summary>
	/// ���[�U�[���}�E�X�̃{�^���������������Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnMouseDown() {
	}

	/// <summary>
	/// ���[�U�[���}�E�X�̃{�^���𗣂����Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnMouseUp() {
	}

	/// <summary>
	/// ���[�U�[��GUIElement��Collider���N���b�N�����܂܁A�}�E�X���ړ������Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnMouseDrag() {
	}

	/// <summary>
	/// Trigger�ɑ���Collider���������Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="other"></param>
	public virtual void OnTriggerEnter(Collider other) {
	}

	/// <summary>
	/// Trigger���瑼��Collider���o���Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="other"></param>
	public virtual void OnTriggerExit(Collider other) {
	}

	/// <summary>
	/// Trigger�ɑ���Collider�����܂��Ă���Ƃ��ɖ��t���[���Ăяo����܂��B
	/// </summary>
	/// <param name="other"></param>
	public virtual void OnTriggerStay(Collider other) {
	}

	/// <summary>
	/// Collider��Rigidbody������Collider��Rigidbody�ɐG�ꂽ�Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="collision"></param>
	public virtual void OnCollisionEnter(Collision collision) {
	}

	/// <summary>
	/// Collider��Rigidbody������Collider��Rigidbody�ɐG�ꑱ���Ă���Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="collisionInfo"></param>
	public virtual void OnCollisionExit(Collision collisionInfo) {
	}

	/// <summary>
	/// Collider��Rigidbody������Collider��Rigidbody�ɐG�ꑱ���Ă���Ƃ��ɖ��t���[���Ăяo����܂��B
	/// </summary>
	/// <param name="collisionInfo"></param>
	public virtual void OnCollisionStay(Collision collisionInfo) {
	}

	/// <summary>
	/// �ړ����ɃR���g���[���[��Collider�ɏՓ˂����Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="hit"></param>
	public virtual void OnControllerColliderHit(ControllerColliderHit hit) {
	}

	/// <summary>
	/// �W���C���g���j�󂳂ꂽ�Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="breakForce"></param>
	public virtual void OnJointBreak(float breakForce) {
	}

	/// <summary>
	/// �p�[�e�B�N����Collider�ɏՓ˂����Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="other"></param>
	public virtual void OnParticleCollision(GameObject other) {
	}

	/// <summary>
	/// �����_���[���J�����ɑ΂��ĉ���ԂɂȂ����Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnBecameVisible() {
	}

	/// <summary>
	/// �����_���[���J�����ɑ΂��ĕs����ԂɂȂ����Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnBecameInvisible() {
	}

	/// <summary>
	/// �V�������x�������[�h���ꂽ�Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="level"></param>
	public virtual void OnLevelWasLoaded(int level) {
	}

	/// <summary>
	/// �I�u�W�F�N�g���L�������ꂽ�Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnEnable() {
	}

	/// <summary>
	/// �I�u�W�F�N�g�����������ꂽ�Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnDisable() {
	}

	/// <summary>
	/// �I�u�W�F�N�g���j������钼�O�ɌĂяo����܂��B
	/// </summary>
	public virtual void OnDestroy() {
	}

	/// <summary>
	/// �J�������V�[�����J�����O����O�ɌĂяo����܂��B
	/// </summary>
	public virtual void OnPreCull() {
	}

	/// <summary>
	/// �J�������V�[���̃����_�����O���J�n����O�ɌĂяo����܂��B
	/// </summary>
	public virtual void OnPreRender() {
	}

	/// <summary>
	/// �J�����̃V�[���������_�����O���I�������Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnPostRender() {
	}

	/// <summary>
	/// �J�������V�[���������_�����O���������Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnRenderObject() {
	}

	/// <summary>
	/// �I�u�W�F�N�g������Ԃ̂Ƃ��A�J�������ƂɈ�x�Ăяo����܂��B
	/// </summary>
	public virtual void OnWillRenderObject() {
	}

	/// <summary>
	/// GUI�̕`��ƃC�x���g�̃n���h�����O�̂��߂ɌĂяo����܂��B
	/// </summary>
	public virtual void OnGUI() {
	}

	/// <summary>
	/// �S�Ẵ����_�[�C���[�W�̃����_�����O�����������Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="source"></param>
	/// <param name="destination"></param>
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination) {
	}

	/// <summary>
	/// �I�������I�u�W�F�N�g�̃M�Y����\������Ƃ��́A���̊֐����������܂��B
	/// </summary>
	public virtual void OnDrawGizmosSelected() {
	}

	/// <summary>
	/// �I�u�W�F�N�g�̃M�Y����\������Ƃ��́A���̊֐����������܂��B
	/// </summary>
	public virtual void OnDrawGizmos() {
	}

	/// <summary>
	/// �A�v���P�[�V�������ꎞ��~�����Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="pause"></param>
	public virtual void OnApplicationPause(bool pause) {
	}

	/// <summary>
	/// �A�v���P�[�V�������t�H�[�J�X���ꂽ�Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="focus"></param>
	public virtual void OnApplicationFocus(bool focus) {
	}

	/// <summary>
	/// �A�v���P�[�V�������I������钼�O�ɌĂяo����܂��B
	/// </summary>
	public virtual void OnApplicationQuit() {
	}

	/// <summary>
	/// �V�����v���C���[���ڑ����ꂽ�Ƃ��ɃT�[�o�[�ŌĂяo����܂��B
	/// </summary>
	/// <param name="player"></param>
	public virtual void OnPlayerConnectedd(NetworkPlayer player) {
	}

	/// <summary>
	/// Network.InitializeServer���Ăяo���ꊮ�������Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnServerInitialized() {
	}

	/// <summary>
	/// �N���C�A���g���T�[�o�[�ɐڑ����������Ƃ��ɌĂяo����܂��B
	/// </summary>
	public virtual void OnConnectedToServer() {
	}

	/// <summary>
	/// �T�[�o�[����v���C���[���ؒf���ꂽ�Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="player"></param>
	public virtual void OnPlayerDisconnected(NetworkPlayer player) {
	}

	/// <summary>
	/// �N���C�A���g���T�[�o�[�ւ̐ڑ����������Ƃ��ɌĂяo����܂��B
	/// </summary>
	/// <param name="info"></param>
	public virtual void OnDisconnectedFromServer(NetworkDisconnection info) {
	}

	/// <summary>
	/// ���炩�̗��R�Őڑ������s�����ꍇ�ɁA�N���C�A���g�ŌĂяo����܂��B
	/// </summary>
	/// <param name="error"></param>
	public virtual void OnFailedToConnect(NetworkConnectionError error) {
	}

	/// <summary>
	/// �}�X�^�[�T�[�o�[�ւ̐ڑ��ɖ�肪���������Ƃ��ɁA�N���C�A���g��T�[�o�[�ŌĂяo����܂��B
	/// </summary>
	/// <param name="info"></param>
	public virtual void OnFailedToConnectToMasterServer(NetworkConnectionError info) {
	}

	/// <summary>
	/// �}�X�^�[�T�[�o�[����̃C�x���g���󂯎�����Ƃ��ɁA�N���C�A���g��T�[�o�[�ŌĂяo����܂��B
	/// </summary>
	/// <param name="msEvent"></param>
	public virtual void OnMasterServerEvent(MasterServerEvent msEvent) {
	}

	/// <summary>
	/// �l�b�g���[�N���Network.Instantiate��p���ăC���X�^���X�����ꂽ�I�u�W�F�N�g�ɑ΂��ČĂяo����܂��B
	/// </summary>
	/// <param name="info"></param>
	public virtual void OnNetworkInstantiate(NetworkMessageInfo info) {
	}

	/// <summary>
	/// �l�b�g���[�N�r���[�ɂ���Ďg����l�̒��񉻂��J�X�^�}�C�Y�������Ƃ��Ɏg���܂��B
	/// </summary>
	/// <param name="stream"></param>
	/// <param name="info"></param>
	public virtual void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info) {
	}
}
