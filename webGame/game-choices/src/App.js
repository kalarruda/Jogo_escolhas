import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import FirstScene from './components/FirstScene';
import SecondScene from './components/SecondScene';

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route path="/second-scene" component={ SecondScene } />
        <Route exact path="/" component={ FirstScene } />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
