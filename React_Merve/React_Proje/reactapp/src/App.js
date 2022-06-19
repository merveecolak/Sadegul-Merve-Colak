// import logo from './logo.svg';
import './App.css';
import User from './components/User'
import Navbar from './components/Navbar';


function App() {
  const test=34;
  const isA=true;
  return (
    <div className="App">
      <h1>Merhaba react</h1>
      <h4>{1+1}</h4>
      <label>{"Merve".toUpperCase()}</label>
      <h4>{test}</h4>
     <div className='header'>
      {
        isA ?  <p>Kullanıcı Kayıtlı</p>
        :null
      }
     </div>
     
     {/* bostrap tükleyip yazı yazdurdık yazı içeriden başladı */}
     <div className='container'>
        <h4>Hello React</h4>

        <Navbar title="User App Merve" />
        <hr/>
        <User
          name="merve"
          maas="600"
          bolum="İst"
        />
      
     </div>

     

    </div>
  );
}

export default App;
